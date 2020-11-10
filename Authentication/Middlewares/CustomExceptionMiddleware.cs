using AuthenticationService.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AuthenticationService.Middlewares
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public CustomExceptionMiddleware(RequestDelegate _next)
        {
            next = _next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next.Invoke(context);
            }
            catch(Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var response = context.Response;

            var exceptionType = ex.GetType();
            var messege = ex.Message;

            if (exceptionType == typeof(UserAlreadyExistsException))
            {
                response.StatusCode = (int)HttpStatusCode.Conflict;
            }
            else if (exceptionType == typeof(System.Exception))
            {
                response.StatusCode = (int)HttpStatusCode.Unauthorized;
            }

            else
            {
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            response.ContentType = "application/json";
            await response.WriteAsync(messege);
        }
    }
}
