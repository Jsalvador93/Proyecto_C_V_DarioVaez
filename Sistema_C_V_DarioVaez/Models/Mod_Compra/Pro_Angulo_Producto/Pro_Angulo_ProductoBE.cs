using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Pro_Angulo_Producto
{
    public class Pro_Angulo_ProductoBE
    {
        public Pro_Producto.Pro_ProductoBE oProducto { get; set; }
        public Pro_Angulo.Pro_AnguloBE oAngulo { get; set; }

        public Pro_Angulo_ProductoBE()
        {
            oProducto = new Pro_Producto.Pro_ProductoBE();

            oAngulo = new Pro_Angulo.Pro_AnguloBE();
        }
    }
}