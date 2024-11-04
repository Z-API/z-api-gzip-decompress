package com.example.springboot;

import java.io.*;
import java.nio.charset.StandardCharsets;
import java.util.zip.GZIPInputStream;

import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class WebhookController {

    @PostMapping(value = "/webhook", consumes = "application/json")
    public String handleWebhook(@RequestBody byte[] compressed) {
        try {
            ByteArrayInputStream byteStream = new ByteArrayInputStream(compressed);
            GZIPInputStream gzipStream = new GZIPInputStream(byteStream);
            BufferedReader reader = new BufferedReader(new InputStreamReader(gzipStream, StandardCharsets.UTF_8));

            StringBuilder decompressedData = new StringBuilder();
            String line;
            while ((line = reader.readLine()) != null) {
                decompressedData.append(line);
            }

            System.out.println("Decompressed payload: " + decompressedData);

            return "Webhook handled successfully";
        } catch (IOException e) {
            System.err.println("Error on decompress: " + e.getMessage());
            return "Error on payload decompress";
        }
    }
}
