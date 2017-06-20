﻿using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace MyWebsite.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await context.Response.WriteAsync($"{GetType().Name} catch exception. Message: {ex.Message}");
            }
        }
    }
}