
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Books.API.Server
{
    public class ApiExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var error = new
            {
                Error = context.Exception.Message,
                StackTrace = context.Exception.StackTrace
            };

            context.ExceptionHandled = true;
            context.Result = new BadRequestObjectResult(error);
        }
    }
}
