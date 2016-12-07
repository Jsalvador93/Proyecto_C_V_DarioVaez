using System.Web.Mvc;

namespace Sistema_C_V_DarioVaez.Areas.Mod_Venta
{
    public class Mod_VentaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Mod_Venta";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Mod_Venta_default",
                "Mod_Venta/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}