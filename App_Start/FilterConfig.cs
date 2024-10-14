using System.Web;
using System.Web.Mvc;

namespace TranMinhHoang23dh11130_ktraFE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
