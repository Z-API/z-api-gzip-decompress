const express = require("express");

const app = express();

app.post("/webhook", express.raw({ type: "application/json" }), (req, res) => {
    const body = JSON.parse(req.body.toString("utf-8"));

    console.log("Body data: ", body.data);

    res.status(200).send("Webhook handled successfully");
});

app.listen(3000, () => {
    console.log("Server running on port 3000");
});
