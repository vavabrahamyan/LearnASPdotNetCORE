using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_WebApplication
{
    public class RoutingMidleware
    {
        RequestDelegate _next;

        public RoutingMidleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path.Value.ToLower();
            if(path == "/" && path == "/home")
            {
                await context.Response.WriteAsync("<h3>Stay at home</h3>");
            }
            else
            {
                context.Response.StatusCode = 403;
            }
        }
    }
}
