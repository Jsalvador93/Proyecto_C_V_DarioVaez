using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_C_V_DarioVaez.Areas.Mod_Compra.Controllers
{
    public class RegistrarCompraController : Controller
    {
        // GET: Mod_Compra/RegistrarCompra
        public ActionResult RegistrarCompra()
        {
            return View();
        }
        public ActionResult _modalAgregarComprador()
        {
            return PartialView();
        }
        public ActionResult _modalAgregarProveedor()
        {
            return PartialView();
        }
        public ActionResult _modalAgregarPedido()
        {
            return PartialView();
        }
    }
}