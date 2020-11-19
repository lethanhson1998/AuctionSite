using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionPage.WebData.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AuctionSite
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AuctionPageDbContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("First hello from middleware 1");
            //    await next.Invoke();
            //    await context.Response.WriteAsync("Second hello from middleware 1");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from middleware 2");
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
