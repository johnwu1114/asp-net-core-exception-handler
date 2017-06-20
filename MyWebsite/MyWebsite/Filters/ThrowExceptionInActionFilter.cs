using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace MyWebsite.Filters
{
    public class ThrowExceptionInActionFilter : IAsyncActionFilter
    {
        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            throw new Exception($"Exception from {GetType().Name}. \r\n");
        }
    }
}