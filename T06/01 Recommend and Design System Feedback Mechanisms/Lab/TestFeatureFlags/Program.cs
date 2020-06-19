using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;

namespace TestFeatureFlags
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
            {
                var settings = config.Build();
                object p = config.AddAzureAppConfiguration(options => {
                    options.Connect(settings["ConnectionStrings:AppConfig"])
                        .UseFeatureFlags(featureFlagOptions => {
                            featureFlagOptions.CacheExpirationTime = TimeSpan.FromMinutes(5);
                        });
                });
            })
            .UseStartup<Startup>());

            public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                    .ConfigureAppConfiguration((hostingContext, config) => {
                        var settings = config.Build();
                        config.AddAzureAppConfiguration(options => {
                            options.Connect(settings["ConnectionStrings:AppConfig"])
                                .UseFeatureFlags(featureFlagOptions => {
                                    featureFlagOptions.CacheExpirationTime = TimeSpan.FromMinutes(5);
                                });
                            });
                    })
                    .UseStartup<Startup>();
        }
}
