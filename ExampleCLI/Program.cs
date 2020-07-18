using System;
using System.Threading.Tasks;
using CommandLine;
using Example;
using Example.Calculators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ExampleCLI
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await Parser.Default.ParseArguments<JsonOptions>(args)
                .WithParsedAsync(async options => await Run(options));
        }

        private static async Task Run(JsonOptions options)
        {
            var serviceProvider = ServiceRegistration.Register();

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            
            logger.LogDebug("Starting building metrics service");

            var service = serviceProvider.GetService<IBuildingMetricsService>();
            var response = await service.Execute(options);

            logger.LogDebug("Calculation completed");
            Console.Read();
        }
    }

    public static class ServiceRegistration
    {
        public static ServiceProvider Register()
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging(builder => builder.AddConsole())
                .AddSingleton<IBuildingMetricsValidator, BuildingMetricsValidator>()
                .AddSingleton<IBuildingMetricsCalculator, BuildingMetricsCalculator>()
                .AddSingleton<IBuildingCalculator, ApartmentCalculator>()
                .AddSingleton<IBuildingMetricsService, BuildingMetricsService>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}