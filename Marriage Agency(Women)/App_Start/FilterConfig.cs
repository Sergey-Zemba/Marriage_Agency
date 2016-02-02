using System.Web;
using System.Web.Mvc;

namespace Marriage_Agency_Women_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
