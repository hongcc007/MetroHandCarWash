
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLog.Web;
using System.Net;

namespace MetroHandCarWash.API
{
    public class ErrorHandlingFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            HandleException(context);
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            logger.Error(context.Exception, "");
        }

        private static void HandleException(ExceptionContext context)
        {
            var result = new JsonResult(new { error = "Number Generation error" });
            result.StatusCode = (int)HttpStatusCode.InternalServerError;

            context.Result = result;
        }
    }
}
