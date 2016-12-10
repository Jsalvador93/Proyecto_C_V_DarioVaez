using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_C_V_DarioVaez.Models.Mod_Compra.Com_Compra
{
    public class Com_CompraDA
    {
        
        public List<Com_Compra_DetalleBE> ListaRegistroCompraDetalle(int dato)
        {
            List<Com_Compra_DetalleBE> oListCompraDetalle = new List<Com_Compra_DetalleBE>();
            using (SqlConnection conexion = Conexion.ConnectionManager.GetConnection())
            {
                try
                {
                    conexion.Open();
                    string strCondicion = string.Empty;
                    using (SqlCommand oSqlCommand = new SqlCommand("SP_PRO_LC_COMPRA_DETALLE", conexion))
                    {
                        if (dato == 0)
                        {
                            strCondicion = "";
                        }
                        else
                        {
                            oSqlCommand.Parameters.Add("@pDato", SqlDbType.VarChar).Value = dato;
                        }
                        oSqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader())
                        {
                            while (oSqlDataReader.Read())
                            {
                                Com_Compra_DetalleBE oCom_DetalleBE = new Com_Compra_DetalleBE();
                                oCom_DetalleBE.oCompraBE.i_idCompra =(int)(oSqlDataReader["i_idCompra"]);
                                oCom_DetalleBE.oPedidoBE.i_idPedido =(int)(oSqlDataReader["i_idPedido"]);
                                oCom_DetalleBE.oProductoBE.vc_dscpProducto =(string)(oSqlDataReader["vc_dscpProducto"]);
                                oCom_DetalleBE.f_prcTotPrdCmprDetalle =(double)(oSqlDataReader["f_prcTotPrdCmprDetalle"]);
                                oCom_DetalleBE.f_cntPrdComDetalle = (double)(oSqlDataReader["f_cntPrdComDetalle"]);
                                oListCompraDetalle.Add(oCom_DetalleBE);
                            }
                            oSqlDataReader.Close();
                        }
                    }
                    conexion.Close();
                    return oListCompraDetalle;
                }
                catch (System.Exception e)
                {

                    return null;
                }
            }
        }

        public List<Com_CompraBE> ListaRegistroCompra(int dato)
        {
            List<Com_CompraBE> oListCompra = new List<Com_CompraBE>();
            using (SqlConnection conexion = Conexion.ConnectionManager.GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand oSqlCommand = new SqlCommand("SP_PRO_LC_LOTE", conexion))
                    {
                        oSqlCommand.Parameters.Add("@pDato", SqlDbType.VarChar).Value = dato;
                        oSqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader())
                        {
                            while (oSqlDataReader.Read())
                            {
                                Com_CompraBE oCom_CompraBE = new Com_CompraBE();
                                oCom_CompraBE.i_idCompra = (int)(oSqlDataReader["i_idCompra"]);
                                oCom_CompraBE.dt_fchCompra = (DateTime)(oSqlDataReader["dt_fchCompra"]);
                                oCom_CompraBE.dt_fchRegistro = (DateTime)(oSqlDataReader["dt_fchRegistro"]);

                                //Integrar los demas modulos
                                oCom_CompraBE.oComprobante.i_idComprobante = (int)(oSqlDataReader[".c_codTipComprobante"]);

                                oListCompra.Add(oCom_CompraBE);
                            }
                            oSqlDataReader.Close();
                        }
                    }
                    conexion.Close();
                    return oListCompra;
                }
                catch (System.Exception e)
                {

                    return null;
                }
            }
        }
    }
}