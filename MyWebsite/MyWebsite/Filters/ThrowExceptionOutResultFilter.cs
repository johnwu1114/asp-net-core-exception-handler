using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace MyWebsite.Filters
{
    public class ThrowExceptionOutResultFilter : IAsyncResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            await next();

            throw new Exception($"Exception from {GetType().Name}. \r\n");
        }
    }
}