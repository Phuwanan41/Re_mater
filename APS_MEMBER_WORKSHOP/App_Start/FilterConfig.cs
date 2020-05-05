using System.Web;
using System.Web.Mvc;

namespace APS_MEMBER_WORKSHOP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
