using Microsoft.EntityFrameworkCore;
using SpotifyP21;
using SpotifyP21.Data;

var host = CreateHostBuilder(args).Build();
host.Run();


static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });