using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Pro_Registro_Producto
{
    public class Pro_Registro_ProductoDA
    {

        public List<Pro_Registro_ProductoBE> ListaRegistroProducto(string dato)
        {
            List<Pro_Registro_ProductoBE> oListPro_Registro_ProductoBE = new List<Pro_Registro_ProductoBE>();
            using (SqlConnection conexion = Conexion.ConnectionManager.GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand oSqlCommand = new SqlCommand("SP_PRO_LC_REGISTRO_PRODUCTO", conexion))
                    {
                        oSqlCommand.Parameters.Add("@pDato", SqlDbType.VarChar).Value = dato;
                        oSqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader())
                        {
                            while (oSqlDataReader.Read())
                            {
                                Pro_Registro_ProductoBE oPro_Registro_ProductoBE = new Pro_Registro_ProductoBE();
                                oPro_Registro_ProductoBE.dt_fchRegistro = (DateTime)(oSqlDataReader["dt_fchRegistro"]);
                                oPro_Registro_ProductoBE.i_stockMaximo = (int)(oSqlDataReader["dt_fchRegistro"]);
                                oPro_Registro_ProductoBE.i_stockMinimo = (int)(oSqlDataReader["i_stockMinimo"]);
                                oPro_Registro_ProductoBE.oProducto.c_codProducto = (string)(oSqlDataReader["c_codProducto"]);
                                oListPro_Registro_ProductoBE.Add(oPro_Registro_ProductoBE);
                                
                            }
                            oSqlDataReader.Close();
                        }
                    }
                    conexion.Close();
                    return oListPro_Registro_ProductoBE;
                }
                catch (System.Exception e)
                {

                    return null;
                }
            }
        }

    }
}