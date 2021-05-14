using System.Threading.Tasks;
using ConsoleAppFramework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ApexRandomBot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) =>
            {
                services.AddOptions();
                services.Configure<Config>(hostContext.Configuration);
            }).RunConsoleAppFrameworkAsync<ApexGacha>(args);
        }
    }
}
