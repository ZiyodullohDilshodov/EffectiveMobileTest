using EffectiveMobile.Service.Exceptions;
using EffectiveMobileTest.Web.Api.Helpers;

namespace EffectiveMobileTest.Web.Api.Middlewares
{
    public class ExceptionHandlerMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlerMiddleware> _logger;
        private long logNumber = 0;

        public ExceptionHandlerMiddleware(RequestDelegate next , ILogger<ExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;

        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (EffectiveMobileException ex)
            {
                _logger.LogError($"{++logNumber} \n {ex.Message}\n");
                context.Response.StatusCode = 200;
                await context.Response.WriteAsJsonAsync(new Response
                {
                    StatusCode = ex.StatusCode,
                    StatusMassage = ex.Message
                });
            }
            catch(Exception ex)
            {
                _logger.LogError($"{++logNumber}:\t{ex.Message}\n");
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync(new Response
                {
                    StatusCode = 500,
                    StatusMassage = ex.Message
                });
            }
        }

    }
}
