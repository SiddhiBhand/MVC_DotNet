using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace ActionFilterMVC.Controllers
{
    public class CasheResourseFilter:IResourceFilter
    {
        private static readonly Dictionary<string, object> _cache = new Dictionary<string, object>();
        private string _cacheKey;
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            _cacheKey = context.HttpContext.Request.Path.ToString();
            if (_cache.ContainsKey(_cacheKey))
            {
                var cachedValue = _cache[_cacheKey] as string;
                if (cachedValue != null)
                {
                    context.Result = new ContentResult() { Content = cachedValue };
                }
            }

        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            if (!String.IsNullOrEmpty(_cacheKey) && !_cache.ContainsKey(_cacheKey))
            {
                var result = context.Result as ContentResult;
                if (result != null)
                {
                    _cache.Add(_cacheKey, result.Content);
                }
            }
        }
    }
    public class CacheResourceAttribute : TypeFilterAttribute
    {
       public CacheResourceAttribute() : base(typeof(CasheResourseFilter))
        {

        }
    }
}
