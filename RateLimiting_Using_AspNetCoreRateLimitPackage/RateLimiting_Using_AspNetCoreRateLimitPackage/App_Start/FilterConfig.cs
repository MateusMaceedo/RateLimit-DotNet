using System.Web;
using System.Web.Mvc;

namespace RateLimiting_Using_AspNetCoreRateLimitPackage
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
