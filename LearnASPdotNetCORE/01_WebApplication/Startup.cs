using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _01_WebApplication
{
    public class Startup
    {
        IWebHostEnvironment _env;
        public Startup(IWebHostEnvironment env)
        {
            _env = env;
        }
        //This method gets called by the runtime.Use this method to add services to the container.
        //For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        //This method gets called by the runtime.Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync($"Application name: {_env.ApplicationName}");
                });
            });
        }
    }
    public class _Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<TokenMiddleware>("5555");
            app.Run(async (context) =>
            {
                context.Response.WriteAsync("Incha axchi");
            });

        }
        private async Task Handle(HttpContext context)
        {
            string host = context.Request.Host.Value;
            string path = context.Request.Path;
            string query = context.Request.QueryString.Value;
            context.Response.ContentType = ("text/html ; charset = utf-8 ");
            await context.Response.WriteAsync($"<h3>ContextHost: {host}</h3>" +
                                        $"<h3>ContextPath: {path}</h3>" +
                $"<h3>ContextQuery: {query}</h3>");
        }
    }
}
