using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ConfigRazorPages.Models.Filters
{
    public class AddHeaderAttribute : Attribute, IResultFilter
    {
        private readonly string _name;
        private readonly string _value;

        public AddHeaderAttribute(string name, string value)
        {
            _value = value;
            _name = name;
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add(_name,new string[] { _value });
        }
    }
}
