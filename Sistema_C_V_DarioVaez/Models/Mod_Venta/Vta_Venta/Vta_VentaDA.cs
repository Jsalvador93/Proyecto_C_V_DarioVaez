﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_C_V_DarioVaez.Models.Mod_Venta.Vta_Venta
{
    public class Vta_VentaDA
    {
        public List<Vta_Venta_DetalleBE> ListaRegistroVentaDetalle(int dato)
        {
            List<Vta_Venta_DetalleBE> oListVentaDetalle = new List<Vta_Venta_DetalleBE>();
            using (SqlConnection conexion = Conexion.ConnectionManager.GetConnection())
            {
                try
                {
                    conexion.Open();
                    string strCondicion = string.Empty;
                    using (SqlCommand oSqlCommand = new SqlCommand("SP_VTA_LC_VENTA_DETALLE", conexion))
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
                                Vta_Venta_DetalleBE oVta_Venta_DetalleBE = new Vta_Venta_DetalleBE();
                                oVta_Venta_DetalleBE.oVentaBE.i_idVenta = (int)(oSqlDataReader["i_idVenta"]);
                                oVta_Venta_DetalleBE.i_idVntDetalle = (int)(oSqlDataReader["i_idVntDetalle"]);
                                oVta_Venta_DetalleBE.f_totalVntDetalle = (Double)(oSqlDataReader["f_totalVntDetalle"]);
                                oVta_Venta_DetalleBE.f_cntPrdVntDetalle = (Double)(oSqlDataReader["f_cntPrdVntDetalle"]);
                                //oVta_Venta_DetalleBE.oProductoBE.c_codProducto = (Char)(oSqlDataReader["c_codProducto"]);

                                oListVentaDetalle.Add(oVta_Venta_DetalleBE);
                            }
                            oSqlDataReader.Close();
                        }
                    }
                    conexion.Close();
                    return oListVentaDetalle;
                }
                catch (System.Exception e)
                {

                    return null;
                }
            }
        }

        public List<Vta_VentaBE> ListaRegistroVenta(int dato)
        {
            List<Vta_VentaBE> oListVenta = new List<Vta_VentaBE>();
            using (SqlConnection conexion = Conexion.ConnectionManager.GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand oSqlCommand = new SqlCommand("SP_VTA_LC_VENTA", conexion))
                    {
                        oSqlCommand.Parameters.Add("@pDato", SqlDbType.VarChar).Value = dato;
                        oSqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader())
                        { 
                            while (oSqlDataReader.Read())
                            {
                                Vta_VentaBE oVta_VentaBE = new Vta_VentaBE();
                                oVta_VentaBE.i_idVenta = (int)(oSqlDataReader["i_idVenta"]);
                                oVta_VentaBE.dt_fchRegistro = (DateTime)(oSqlDataReader["dt_fchRegistro"]);
                                //oVta_VentaBE.oUsuarioBE.vc_codUsuario = (string)(oSqlDataReader["vc_codUsuario"]);
                                //oVta_VentaBE.oPersonaBE.i_idPersona = (int)(oSqlDataReader["i_idPersona"]);
                                oVta_VentaBE.oListVentaDetalle = ListaRegistroVentaDetalle(oVta_VentaBE.i_idVenta);
                                oListVenta.Add(oVta_VentaBE);
                            }
                            oSqlDataReader.Close();
                        }
                    }
                    conexion.Close();
                    return oListVenta;
                }
                catch (System.Exception e)
                {

                    return null;
                }
            }
        }
    }
}