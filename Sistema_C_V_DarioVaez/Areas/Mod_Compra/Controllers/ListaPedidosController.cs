using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_C_V_DarioVaez.Areas.Mod_Compra.Controllers
{
    public class ListaPedidosController : Controller
    {
        // GET: Mod_Compra/ListaPedidos
        public ActionResult ListaPedidos()
        {
            return View();
        }
        public ActionResult _modalDetalle()
        {
            return PartialView();
        }
        public ActionResult _modalGenerar()
        {
            return PartialView();
        }
    }
}