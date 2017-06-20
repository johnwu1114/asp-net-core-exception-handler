using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace MyWebsite.Middlewares
{
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;

        public FirstMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.Value.IndexOf("/error/middleware/before-action", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                throw new Exception($"Exception from {GetType().Name} in. \r\n");
            }

            await context.Response.WriteAsync($"{GetType().Name} in. \r\n");

            await _next(context);

            if (context.Request.Path.Value.IndexOf("/error/middleware/after-action", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                throw new Exception($"Exception from {GetType().Name} out. \r\n");
            }

            await context.Response.WriteAsync($"{GetType().Name} out. \r\n");
        }
    }
}