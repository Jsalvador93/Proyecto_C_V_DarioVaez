﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Pro_SubCategoria
{
    public class Pro_SubCategoriaBE
    {
        public int i_idSubcategoria { get; set; }
        public string vc_dscpSubCategoria { get; set; }
        public Pro_Categoria.Pro_CategoriaBE oCategoria { get; set; }

        public Pro_SubCategoriaBE()
        {
            oCategoria = new Pro_Categoria.Pro_CategoriaBE();

        }
    }
}