package main

import (
	"bytes"
	"compress/gzip"
	"fmt"
	"github.com/gin-gonic/gin"
	"io"
	"net/http"
)

func main() {
	r := gin.Default()

	r.POST("/webhook", func(c *gin.Context) {
		body, err := io.ReadAll(c.Request.Body)
		if err != nil {
			c.String(http.StatusInternalServerError, "Failed on read request body")
			return
		}

		reader, err := gzip.NewReader(bytes.NewReader(body))
		if err != nil {
			c.String(http.StatusInternalServerError, "Failed on create gzip reader")
			return
		}

		defer func(reader *gzip.Reader) {
			err := reader.Close()
			if err != nil {
				c.String(http.StatusInternalServerError, "Failed on close gzip reader")
			}
		}(reader)

		decompressedBody, err := io.ReadAll(reader)
		if err != nil {
			c.String(http.StatusInternalServerError, "Failed on decompress request body")
			return
		}

		fmt.Println("Decompressed payload", string(decompressedBody))

		c.String(http.StatusOK, string(decompressedBody))
	})

	r.Run(":3000")
}
