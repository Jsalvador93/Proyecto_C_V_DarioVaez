using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Pro_Registro_Producto
{
    public class Pro_Registro_ProductoBE
    {
        public DateTime dt_fchRegistro { get; set; }
        public Pro_Producto.Pro_ProductoBE oProducto { get; set; }
        public int i_stockMaximo { get; set; }
        public int i_stockMinimo { get; set; }

        public Pro_Registro_ProductoBE()
        {
            oProducto = new Pro_Producto.Pro_ProductoBE();
        }

    }
}