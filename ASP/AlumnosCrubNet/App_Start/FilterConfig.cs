using System.Web;
using System.Web.Mvc;

namespace AlumnosCrubNet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //tipo de seguirdad de la aplicacion roles.
            filters.Add(new HandleErrorAttribute());
        }
    }
}
