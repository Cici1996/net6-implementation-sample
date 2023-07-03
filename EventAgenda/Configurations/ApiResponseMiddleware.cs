using EventAgenda.Models.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace EventAgenda.Configurations
{
    public class ApiResponseMiddleware
    {
        private readonly RequestDelegate _next;

        public ApiResponseMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
#if DEBUG
                Debugger.Break();
#endif
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.Headers["Content-Type"] = "application/json; charset=utf-8";
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(new BaseResponseModel
            {
                Succcess = false,
                Data = exception.ToString()
            }));
        }
    }
}