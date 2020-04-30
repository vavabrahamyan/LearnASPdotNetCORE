using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WebApplication
{
    public class RoutingMiddleware
    {
        RequestDelegate _next;
        public RoutingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path.Value.ToLower();
            if (path == "/" || path == "/home")
            {
                await context.Response.WriteAsync("<h3>Stay at home</h3>");
            }
            else if (path == "/outside")
            {
                await context.Response.WriteAsync("<h3>Go home</h3>");
            }
            else 
            {
               await  context.Response.WriteAsync("<h3>Go home now!!!  Please</h3>");
                 context.Response.StatusCode = 403;
            }
        }
    }
    public static class AppExtentions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RoutingMiddleware>();
        }
    }
}
