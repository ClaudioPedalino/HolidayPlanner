using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HolidayPlanner.Api.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;


        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task InvokeAsync(HttpContext httpContext)
        {
            var path = httpContext.Request.Path;
            var httpVerb = httpContext.Request.Method;

            System.Console.WriteLine($"Http method: {path}");
            System.Console.WriteLine($"Path: {httpVerb}");

            await _next(httpContext);

        }
    }
}
