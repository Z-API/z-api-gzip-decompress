using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;

namespace WebhookReceiver
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public class WebhookController : ControllerBase
    {
        [HttpPost("webhook")]
        public async Task<IActionResult> ReceiveWebhook()
        {
            // Obtendo o corpo da requisição como um stream GZIP
            using var gzipStream = new GZipStream(Request.Body, CompressionMode.Decompress);
            using var reader = new StreamReader(gzipStream, Encoding.UTF8);
            
            // Lendo o conteúdo descomprimido
            var content = await reader.ReadToEndAsync();

            // Processando o conteúdo do webhook
            // Aqui você pode adicionar a lógica para lidar com o conteúdo recebido
            return Ok(new { message = "Webhook received successfully", content });
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
