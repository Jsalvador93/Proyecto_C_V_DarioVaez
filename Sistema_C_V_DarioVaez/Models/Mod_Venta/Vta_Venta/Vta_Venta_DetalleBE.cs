﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sistema_C_V_DarioVaez.Models.Mod_Compra.Pro_Producto;


namespace Sistema_C_V_DarioVaez.Models.Mod_Venta.Vta_Venta
{
    public class Vta_Venta_DetalleBE
    {
        public int i_idVntDetalle { get; set; }
        public double f_totalVntDetalle { get; set; }
        public double f_cntPrdVntDetalle { get; set; }
        public Vta_VentaBE oVentaBE { get; set; }
        public Pro_ProductoBE oProductoBE { get; set; }

        public Vta_Venta_DetalleBE()
        {
            oVentaBE = new Vta_VentaBE();
            oProductoBE = new Pro_ProductoBE();





        }

    }
}