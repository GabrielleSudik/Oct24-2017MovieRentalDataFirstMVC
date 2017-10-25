using System.Web;
using System.Web.Mvc;

namespace Oct24_2017MovieRentalDataFirstMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
