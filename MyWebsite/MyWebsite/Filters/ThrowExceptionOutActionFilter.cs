using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace MyWebsite.Filters
{
    public class ThrowExceptionOutActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await next();

            throw new Exception($"Exception from {GetType().Name}. \r\n");
        }
    }
}