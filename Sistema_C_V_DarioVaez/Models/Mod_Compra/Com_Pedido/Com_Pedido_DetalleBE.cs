using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Com_Pedido
{
    public class Com_Pedido_DetalleBE
    {
        public Com_PedidoBE oPedidoBE { get; set; }
        public Pro_Producto.Pro_ProductoBE oProductoBE { get; set; }
        public double f_prcUntReferencial { get; set; }
        public double f_cntPrdPdo { get; set; }
        public Com_Pedido_DetalleBE()
        {
            oPedidoBE = new Com_PedidoBE();
            oProductoBE = new Pro_Producto.Pro_ProductoBE();
        }
    }
}