using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using DynamicForms.DataProvider.Implementation;
using DynamicForms.DataProvider.Interface;

namespace DynamicForms
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Setup options with DI
            services.AddOptions();

            // Configure ConnectionStrings using config
            //services.Configure<ConnectionStrings>(Configuration);

            OptionsConfigurationServiceCollectionExtensions.Configure<ConnectionStrings>(services, Configuration.GetSection("ConnectionStrings"));
            services.AddTransient<IListDataProvider, ListDataProvider>();
            services.AddTransient<IListEntryDataProvider, ListEntryDataProvider>();
            services.AddTransient<IListFieldDataProvider, ListFieldDataProvider>();
            services.AddTransient<IListValueDataProvider, ListValueDataProvider>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
