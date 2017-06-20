using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace MyWebsite.Filters
{
    public class ThrowExceptionInResultFilter : IAsyncResultFilter
    {
        public Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            throw new Exception($"Exception from {GetType().Name}. \r\n");
        }
    }
}