using BlazorWebAssemblyWithPrerendering.Shared;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWebAssemblyWithPrerendering.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IWeatherForecastService, HttpWeatherForecastService>();
            services.AddSingleton<IPrerenderingService, WasmPrerenderingService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
