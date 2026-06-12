using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;

namespace AuthorizationFilter.Models.Filters
{
    public class CacheResourceFilter : IResourceFilter
    {
        private readonly IModelMetadataProvider _modelMetadataProvider;

        public CacheResourceFilter(IModelMetadataProvider modelMetadataProvider)
        {
            _modelMetadataProvider = modelMetadataProvider;
        }

        private static readonly Dictionary<string, object> _cache = new Dictionary<string, object>();
        private string _cacheKey;
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            _cacheKey=context.HttpContext.Request.Path.ToString();

            if (_cache.ContainsKey(_cacheKey))
            {
                var cachedData=_cache[_cacheKey] as string;
                if (cachedData != null)
                {
                    context.Result = new ViewResult()
                    {
                        ViewName = "Index",
                        ViewData = new ViewDataDictionary(_modelMetadataProvider, context.ModelState)
                        {
                            Model = cachedData
                        }
                    };
                }
            }
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            if (!string.IsNullOrEmpty(_cacheKey) && !_cache.ContainsKey(_cacheKey))
            {
                var result = context.Result as ViewResult;
                if (result != null)
                {
                    _cache.Add(_cacheKey, result.Model);
                }
            }
        }

    }
}
