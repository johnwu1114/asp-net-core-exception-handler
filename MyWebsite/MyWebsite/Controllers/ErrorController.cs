using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Filters;
using MyWebsite.Middlewares;
using System;

namespace MyWebsite.Controllers
{
    [TypeFilter(typeof(AuthorizationFilter))]
    [Route("[controller]")]
    public class ErrorController : Controller
    {
        private const string _message = "Hello~ I'm Action.\r\n";

        public void Index()
        {
            throw new Exception("Exception from Action.\r\n");
        }

        [Route("action-filter/before-action")]
        [TypeFilter(typeof(ThrowExceptionInActionFilter))]
        public void ActionFilter_BeforeAction()
        {
            HttpContext.Response.WriteAsync(_message);
        }

        [Route("action-filter/after-action")]
        [TypeFilter(typeof(ThrowExceptionOutActionFilter))]
        public void ActionFilter_AfterAction()
        {
            HttpContext.Response.WriteAsync(_message);
        }


        [Route("result-filter/before-action")]
        [TypeFilter(typeof(ThrowExceptionInResultFilter))]
        public void ResultFilter_BeforeAction()
        {
            HttpContext.Response.WriteAsync(_message);
        }

        [Route("result-filter/after-action")]
        [TypeFilter(typeof(ThrowExceptionOutResultFilter))]
        public void ResultFilter_AfterAction()
        {
            HttpContext.Response.WriteAsync(_message);
        }

        [Route("resource-filter/before-action")]
        [TypeFilter(typeof(ThrowExceptionInResourceFilter))]
        public void ResourceFilter_BeforeAction()
        {
            HttpContext.Response.WriteAsync(_message);
        }

        [Route("resource-filter/after-action")]
        [TypeFilter(typeof(ThrowExceptionOutResourceFilter))]
        public void ResourceFilter_AfterAction()
        {
            HttpContext.Response.WriteAsync(_message);
        }

        [Route("middleware/before-action")]
        public void Middleware_BeforeAction()
        {
            HttpContext.Response.WriteAsync(_message);
        }

        [Route("middleware/after-action")]
        public void Middleware_AfterAction()
        {
            HttpContext.Response.WriteAsync(_message);
        }
    }
}