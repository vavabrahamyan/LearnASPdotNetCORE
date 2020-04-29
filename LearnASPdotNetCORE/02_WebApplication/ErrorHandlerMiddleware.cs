using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WebApplication
{
    public class ErrorHandlerMiddleware
    {
        RequestDelegate _next;
        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);
            if(context.Response.StatusCode == 403)
            {
                context.Response.WriteAsync("Error 403");
            }
            else if(context.Response.StatusCode == 404)
            {
                context.Response.WriteAsync("Error 404");

            }
        }
    }
}
