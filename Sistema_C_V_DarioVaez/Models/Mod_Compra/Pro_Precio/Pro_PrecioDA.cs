using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Pro_Precio
{
    public class Pro_PrecioDA
    {
        public List<Pro_PrecioBE> ListaRegistroPrecio(string dato)
        {
            List<Pro_PrecioBE> oListPro_PrecioBE = new List<Pro_PrecioBE>();
            using (SqlConnection conexion = Conexion.ConnectionManager.GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand oSqlCommand = new SqlCommand("SP_PRO_LC_PRECIO", conexion))
                    {
                        oSqlCommand.Parameters.Add("@pDato", SqlDbType.VarChar).Value = dato;
                        oSqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader())
                        {
                            while (oSqlDataReader.Read())
                            {
                                Pro_PrecioBE oPro_PrecioBE = new Pro_PrecioBE();
                                oPro_PrecioBE.dt_fchRgtrPrecio = (DateTime)(oSqlDataReader["dt_fchRgtrPrecio"]);
                                oPro_PrecioBE.f_prcCompra = (float)(oSqlDataReader["f_prcCompra"]);
                                oPro_PrecioBE.f_prcVenta = (float)(oSqlDataReader["f_prcVenta"]);
                                oPro_PrecioBE.f_utilidad = (float)(oSqlDataReader["f_utilidad"]);
                                oPro_PrecioBE.f_prcVntNeto = (float)(oSqlDataReader["f_prcVntNeto"]);
                                oPro_PrecioBE.oProducto.c_codProducto = (string)(oSqlDataReader["c_codProducto"]);
                                oListPro_PrecioBE.Add(oPro_PrecioBE);
                            }
                            oSqlDataReader.Close();
                        }
                    }
                    conexion.Close();
                    return oListPro_PrecioBE;
                }
                catch (System.Exception e)
                {

                    return null;
                }
            }
        }
    }
}