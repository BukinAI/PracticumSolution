using System.Net;
using System.Text;


namespace BookHouse.Infrastructure
{
    /// <summary>
    /// 2.2.3 Логирование времени запроса
    /// </summary>
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate request;
        private readonly ILogger<ExceptionMiddleware> logger;


        public ExceptionMiddleware(RequestDelegate request, ILogger<ExceptionMiddleware> logger)
        {
            this.request = request;
            this.logger = logger;

        }
                
        public async Task Invoke(HttpContext context)
        {
            try
            {
                logger.LogInformation("" + DateTime.Now + " " + "Request method:" + context.Request.Method + " start " + "Path:" + context.Request.Path);
                await request(context);
                logger.LogInformation("" + DateTime.Now + " " + "Request method:" + context.Request.Method + " end " + "Path:" + context.Request.Path);
            }
            catch (Exception exception)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "text";
                logger.LogError(exception, "" + DateTime.Now + " " + "Неизвестная ошибка : " + exception.Message);
                await context.Response.WriteAsync("Неизвестная ошибка : " + exception.Message, Encoding.UTF8);
            }

        }
    }
    
}
