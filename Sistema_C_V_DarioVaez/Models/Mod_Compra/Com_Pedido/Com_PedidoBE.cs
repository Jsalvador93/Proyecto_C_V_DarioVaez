using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Com_Pedido
{
    public class Com_PedidoBE
    {
        public int i_idPedido { get; set; }
        public DateTime dt_fchRgtPedido { get; set; }

        /*public string vc_codUsuarioSolicitador { get; set; }

        public Byte ti_idTipEstado { get; set; }
        
        public Byte ti_idEstado { get; set; }*/

        public List<Com_Pedido_DetalleBE> oListPedidoDetalle { get; set; }
        public List<Com_PedidoBE> oListPedido { get; set; }
        public Com_PedidoBE()
        {
            oListPedidoDetalle = new List<Com_Pedido_DetalleBE>();
            oListPedido = new List<Com_PedidoBE>();
        }
    }
}