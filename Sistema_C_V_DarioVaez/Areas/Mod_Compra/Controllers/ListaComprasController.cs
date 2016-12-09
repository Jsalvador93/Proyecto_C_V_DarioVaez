using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_C_V_DarioVaez.Areas.Mod_Compra.Controllers
{
    public class ListaComprasController : Controller
    {
        // GET: Mod_Compra/ListaCompras
        public ActionResult ListaCompras()
        {
            return View();
        }
        public ActionResult _modalDetalle()
        {
            return PartialView();
        }
    }
}