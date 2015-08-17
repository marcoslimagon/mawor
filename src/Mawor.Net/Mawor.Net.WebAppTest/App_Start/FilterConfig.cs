using System.Web;
using System.Web.Mvc;

namespace Mawor.Net.WebAppTest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}