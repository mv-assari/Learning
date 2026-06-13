using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace AuthorizationFilter.Models.Filters
{
    public class AddHeaderFilter : Attribute, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("MyHeaderOnFilter", "this is a test add header");
        }
        public void OnResultExecuted(ResultExecutedContext context)
        {

        }

    }
}
