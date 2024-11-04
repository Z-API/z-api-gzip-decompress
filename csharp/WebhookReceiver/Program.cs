using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.IO.Compression;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapControllers();

app.MapPost("/webhook", async (HttpRequest request) =>
{
    using var gzipStream = new GZipStream(request.Body, CompressionMode.Decompress);
    using var reader = new StreamReader(gzipStream, Encoding.UTF8);

    var content = await reader.ReadToEndAsync();

    Console.WriteLine("Webhook payload data:");
    Console.WriteLine(content);

    return Results.Ok(new { message = "Webhook handled successfully", content });
});

app.Run();
