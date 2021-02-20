using Core.Ports;
using Core.Services;
using Infrastructure.Adapters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace DSL.Partiel01.ConsoleApp
{
    class Program
    {
        static Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            Run(host.Services);

            return host.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) => services
                    .AddTransient<IInterpretCommand, IdpInterpretCommand>()
                    .AddTransient<ComplexeService>());

        static void Run(IServiceProvider services)
        {
            using IServiceScope serviceScope = services.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;

            ComplexeService complexeService = provider.GetRequiredService<ComplexeService>();

            new Alexoogle().Demo(complexeService);
        }
    }
}
