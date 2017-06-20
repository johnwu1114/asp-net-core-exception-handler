using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace MyWebsite.Filters
{
    public class ThrowExceptionOutResourceFilter : IAsyncResourceFilter
    {
        public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            await next();

            throw new Exception($"Exception from {GetType().Name}. \r\n");
        }
    }
}