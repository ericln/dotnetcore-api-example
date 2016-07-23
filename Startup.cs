
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using HWAPP.Services;

namespace HWAPP
{
    public class Startup 
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Information);
            loggerFactory.AddDebug();

            app.UseMvc();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            registerDependency(services);
        }

        private void registerDependency(IServiceCollection services) {
            services.AddTransient<IBatchService, BatchService>();
        }
    }
}