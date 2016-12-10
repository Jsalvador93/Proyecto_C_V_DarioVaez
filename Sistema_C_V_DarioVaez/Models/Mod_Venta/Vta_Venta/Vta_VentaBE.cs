using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_C_V_DarioVaez.Models.Mod_Venta.Vta_Venta
{
    public class Vta_VentaBE
    {
        public int i_idVenta { get; set; }
        public DateTime dt_fchRegistro { get; set; }
        //public Rol_Usuario.Rol_UsuarioBE oUsuarioBE{get; set;}
        //public Pers_Persona.Pers_PersonaBE oPersonaBE{get; set;}



       

        public List<Vta_Venta_DetalleBE> oListVentaDetalle { get; set; }
        public List<Vta_VentaBE> oVenta { get; set; }
        public Vta_VentaBE()
        {
            oListVentaDetalle = new List<Vta_Venta_DetalleBE>();
            oVenta = new List<Vta_VentaBE>();
        }


    }
}