using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_C_V_DarioVaez.Areas.Mod_Almacen.Controllers
{
    public class RegistrarProductoController : Controller
    {
        // GET: Mod_Almacen/RegistrarProducto
        public ActionResult RegistrarProducto()
        {
            return View();
        }
        public ActionResult _modalSeccion()
        {
            return PartialView();
        }
        public ActionResult _modalTipoProducto()
        {
            return PartialView();
        }
        public ActionResult _modalMarca()
        {
            return PartialView();
        }
        public ActionResult _modalLote()
        {
            return PartialView();
        }
        public ActionResult _modalUbicacion()
        {
            return PartialView();
        }
        public ActionResult _modalCategoria()
        {
            return PartialView();
        }
        public ActionResult _modalSubCategoria()
        {
            return PartialView();
        }
        public ActionResult _modalAngulo()
        {
            return PartialView();
        }
    }
}