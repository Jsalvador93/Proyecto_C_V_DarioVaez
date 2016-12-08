using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_C_V_DarioVaez.Areas.Mod_Venta.Controllers
{
    public class ListaVentasController : Controller
    {
        // GET: Mod_Venta/ListaVentas
        public ActionResult ListaVentas()
        {
            return View();
        }
        public ActionResult _modalDetalles()
        {
            return PartialView();
        }
        public ActionResult _modalGenerar()
        {
            return PartialView();
        }
    }
}