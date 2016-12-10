using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Pro_Lote
{
    public class Pro_LoteBE
    {
        public byte i_idLote { get; set; }
        public DateTime dt_fchFabricacion { get; set; }
        public DateTime dt_fchVencimiento { get; set; }
        public List<Pro_Lote_DetalleBE> oListLoteDetalle { get; set; }
        public List<Pro_LoteBE> oListLote { get; set; }
        public Pro_LoteBE()
        {
            oListLoteDetalle = new List<Pro_Lote_DetalleBE>();
            oListLote = new List<Pro_LoteBE>();
        }
    }
}