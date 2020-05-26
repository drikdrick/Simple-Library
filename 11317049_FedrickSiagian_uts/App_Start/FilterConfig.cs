using System.Web;
using System.Web.Mvc;

namespace _11317049_FedrickSiagian_uts
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
