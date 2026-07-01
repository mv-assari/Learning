using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ConfigRazorPages.Models.Filters
{
    //با این خصوصیت که از نوع فیلتر هست میتوان یه فیلتر سراسری برای تمام یا هر صفحه ای جدا گونه انجام بدیم
    public class MyPageFilter : Attribute, IPageFilter
    {
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            throw new NotImplementedException();
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            throw new NotImplementedException();
        }
    }
}
