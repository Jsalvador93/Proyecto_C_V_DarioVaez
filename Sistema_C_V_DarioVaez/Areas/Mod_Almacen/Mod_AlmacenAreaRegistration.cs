using System.Web.Mvc;

namespace Sistema_C_V_DarioVaez.Areas.Mod_Almacen
{
    public class Mod_AlmacenAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Mod_Almacen";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Mod_Almacen_default",
                "Mod_Almacen/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}