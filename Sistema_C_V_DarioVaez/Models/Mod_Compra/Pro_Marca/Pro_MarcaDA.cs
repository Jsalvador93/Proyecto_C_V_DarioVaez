using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Pro_Marca
{
    public class Pro_MarcaDA
    {
        public List<Pro_MarcaBE> ListaRegistroMarca(String dato)
        {
            List<Pro_MarcaBE> oListPro_MarcaBE = new List<Pro_MarcaBE>();
            SqlConnection conexion = Conexion.ConnectionManager.GetConnection();
            conexion.Open();
            SqlCommand oSqlCommand = new SqlCommand("SP_PRO_LC_MARCA", conexion);
            oSqlCommand.Parameters.Add("@pDato", SqlDbType.VarChar).Value = dato;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader();

            while (oSqlDataReader.Read())
            {
                Pro_MarcaBE oPro_MarcaBE = new Pro_MarcaBE();
                oPro_MarcaBE.i_idMarca = (int)(oSqlDataReader["i_idMarca"]);
                oPro_MarcaBE.vc_dscpMarca = (string)(oSqlDataReader["vc_dscpMarca"]);
                oListPro_MarcaBE.Add(oPro_MarcaBE);
            }
            oSqlDataReader.Close();
            conexion.Close();
            return oListPro_MarcaBE;
        }
    }
}