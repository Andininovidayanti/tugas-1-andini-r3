using System.Web;
using System.Web.Mvc;

namespace ANDINI_NOVIDAYANTI_ARDININGRUM_03_XI_R3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
