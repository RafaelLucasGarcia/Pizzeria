using Autofac.Integration.WebApi;
using Microsoft.Owin.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace PizzaShop.App_Start
{
    public class LoggingActionFilter : IAutofacActionFilter
    {
        readonly ILogger _logger;

        public LoggingActionFilter(ILogger logger)
        {
            _logger = logger;
        }

        public Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            _logger.WriteError(actionContext.ActionDescriptor.ActionName);
            return Task.FromResult(0);
        }

        public Task OnActionExecutedAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            _logger.WriteError(actionExecutedContext.ActionContext.ActionDescriptor.ActionName);
            return Task.FromResult(0);
        }
    }
}