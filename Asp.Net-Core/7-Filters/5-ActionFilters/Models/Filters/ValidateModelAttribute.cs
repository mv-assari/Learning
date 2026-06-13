using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace AuthorizationFilter.Models.Filters
{
    public class ValidateModelAttribute :Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)//قبل از اجرای اکشن این مورد اجرا میشود
        {
            var param = context.ActionArguments.SingleOrDefault();
            if (param.Value==null)
            {
                context.Result = new BadRequestObjectResult("Model is null");
            }

            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)//بعد از اجرای اکشن این مورد اجرا میشود
        {
           
        }

    }
}
