using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProySuministros.Presentation.Layer.Middlewares
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate next;
        public ErrorMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                string mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                await context.Response.WriteAsync(new
                {
                    StatusCode = context.Response.StatusCode,
                    Message = mensaje
                }.ToString());
            }
        }
    }
}
