using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Com_Compra
{
    public class Com_CompraBE
    {
        public int i_idCompra { get; set; }
        public DateTime dt_fchCompra { get; set; }
        public DateTime dt_fchRegistro { get; set; }

        //public string vc_idUsuarioComprador { get; set; }

        //public string vc_idUsuarioRegistrador { get; set; }
        public Mod_Venta.Cprb_Comprobante.Cprb_ComprobanteBE oComprobante { get; set; }

        //public int i_idPersona { get; set; }

        public List<Com_Compra_DetalleBE> oListCompraDetalle { get; set; }
        public List<Com_CompraBE> oListCompra { get; set; }

        public Com_CompraBE()
        {
            oComprobante = new Mod_Venta.Cprb_Comprobante.Cprb_ComprobanteBE();
            oListCompraDetalle = new List<Com_Compra_DetalleBE>();
            oListCompra = new List<Com_CompraBE>();
        }
    }
}