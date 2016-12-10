using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Pro_Producto
{
    public class Pro_ProductoDA
    {
        public List<Pro_ProductoBE> ListaRegistroProducto(string dato)
        {
            List<Pro_ProductoBE> oListPro_ProductoBE = new List<Pro_ProductoBE>();
            using (SqlConnection conexion = Conexion.ConnectionManager.GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand oSqlCommand = new SqlCommand("SP_PRO_LC_PRODUCTO", conexion))
                    {
                        oSqlCommand.Parameters.Add("@pDato", SqlDbType.VarChar).Value = dato;
                        oSqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader())
                        {
                            while (oSqlDataReader.Read())
                            {
                                Pro_ProductoBE oPro_ProductoBE = new Pro_ProductoBE();
                                oPro_ProductoBE.c_codProducto = (string)(oSqlDataReader["c_codProducto"]);
                                oPro_ProductoBE.vc_dscpProducto = (string)(oSqlDataReader["vc_dscpProducto"]);
                                oPro_ProductoBE.oSeccionBE.vc_dscpSeccion = (string)(oSqlDataReader["vc_dscpSeccion"]);
                                oPro_ProductoBE.oTipoProductoBE.vc_dscpTipProducto = (string)(oSqlDataReader["vc_dscpTipProducto"]);
                                oPro_ProductoBE.oMarcaBE.vc_dscpMarca = (string)(oSqlDataReader["vc_dscpMarca"]);
                                oListPro_ProductoBE.Add(oPro_ProductoBE);
                            }
                            oSqlDataReader.Close();
                        }
                    }
                    conexion.Close();
                    return oListPro_ProductoBE;
                }
                catch (System.Exception e)
                {

                    return null;
                }
            }
        }
    }
}