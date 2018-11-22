using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoloSong.Controllers
{
    public class MineMiddleware
    {
        private readonly RequestDelegate _next;

        public MineMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Headers.ContainsKey("Authorization"))
            {
                var basicToken = context.Request.Headers["Authorization"].ToString();
                basicToken = basicToken.Replace("Basic ", "");
                //Kiểm tra database
                await _next(context);
            }
            else
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Forbidden");
            }
        }

    }

    public static class MineMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestCulture(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MineMiddleware>();
        }
    }

}
