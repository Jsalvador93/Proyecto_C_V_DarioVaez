using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Pro_Precio
{
    public class Pro_PrecioBE
    {
        public DateTime dt_fchRgtrPrecio { get; set; }
        public Pro_Producto.Pro_ProductoBE oProducto { get; set; }
        public float f_prcCompra { get; set; }
        public float f_prcVenta { get; set; }
        public float f_utilidad { get; set; }
        public float f_prcVntNeto { get; set; }

        public Pro_PrecioBE()
        {
            oProducto = new Pro_Producto.Pro_ProductoBE();
        }
    }
}