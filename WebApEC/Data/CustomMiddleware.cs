using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApEC.Data
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next; 
        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("This is the custom middelware");
           // await _next(context);
           // await context.Response.WriteAsync("Response sent");
        }
    }
}

