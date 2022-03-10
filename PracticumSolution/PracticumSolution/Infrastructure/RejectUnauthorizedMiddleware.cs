using System.Net;

namespace BookHouse.Infrastructure
{
    /// <summary>
    /// 2.2.4 - Проверка хедера "Authorization"
    /// </summary>
    public class RejectUnauthorizedMiddleware
    {
        private readonly RequestDelegate request;


        public RejectUnauthorizedMiddleware(RequestDelegate request)
        {
            this.request = request;
        }

        public Task Invoke(HttpContext context)
        {
            var authHeaders = context.Request.Headers["Authorization"];
            if (authHeaders.Count == 0)
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                return context.Response.WriteAsync("");
            }
            var credentials = authHeaders.ToString().Split(':');

            if (credentials.Length != 2)
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                return context.Response.WriteAsync("");
            }

            var user = credentials[0] ?? String.Empty;
            var pass = credentials[1] ?? String.Empty;

            if (user != "Basic admin" || pass != "admin")
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                return context.Response.WriteAsync("");
            }

            return request(context);
        }
    }
}
