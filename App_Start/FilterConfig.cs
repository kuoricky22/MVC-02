using System.Web;
using System.Web.Mvc;

namespace MVC_03_公司練習
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
