using System.Web;
using System.Web.Mvc;

namespace Area_CustomError_DataAnnotation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
