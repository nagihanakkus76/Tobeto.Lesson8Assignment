using Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions
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
            catch (Exception exception)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status400BadRequest;

                if (exception is BusinessException)
                {
                    var problemDetail = new BusinessProblemDetails(exception.Message);
                    await context.Response.WriteAsync(JsonSerializer.Serialize(problemDetail));
                }
                else if (exception is ValidationException)
                {
                    var problemDetail = new ValidationProblemDetails(exception.Message);
                    await context.Response.WriteAsync(JsonSerializer.Serialize(problemDetail));
                }
                else
                {
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                }

            }
        }
    }
}