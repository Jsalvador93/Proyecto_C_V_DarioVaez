using System.Web.Mvc;

namespace Sistema_C_V_DarioVaez.Areas.Mod_Compra
{
    public class Mod_CompraAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Mod_Compra";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Mod_Compra_default",
                "Mod_Compra/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}