using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_WebApplication
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
            if(path == "/" || path == "/home")
            {
                context.Response.WriteAsync("Stay At Home");
            }
            else if(path == "/otuside")
            {
                context.Response.WriteAsync("Go Home");
            }
            else
            {
                context.Response.StatusCode = 404;
            }
        }
    }
}
