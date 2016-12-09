using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_C_V_DarioVaez.Areas.Mod_Almacen.Controllers
{
    public class ListaProductoController : Controller
    {
        // GET: Mod_Almacen/ListaProducto
        public ActionResult ListaProducto()
        {
            return View();
        }
        public ActionResult _modalDetalle()
        {
            return PartialView();
        }
    }
}