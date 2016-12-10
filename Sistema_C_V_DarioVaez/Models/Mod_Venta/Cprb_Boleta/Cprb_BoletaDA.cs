using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace Sistema_C_V_DarioVaez.Models.Mod_Venta.Cprb_Boleta
{
    public class Cprb_BoletaDA
    {
        public List<Cprb_BoletaBE> ListaRegistroBoleta(string dato)
        {
            List<Cprb_BoletaBE> oListCpr_BoletaBE = new List<Cprb_BoletaBE>();
            using (SqlConnection conexion = Conexion.ConnectionManager.GetConnection())
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand oSqlCommand = new SqlCommand("SP_CPRB_LC_BOLETA", conexion))
                    {
                        oSqlCommand.Parameters.Add("@pDato", SqlDbType.VarChar).Value = dato;
                        oSqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader oSqlDataReader = oSqlCommand.ExecuteReader())
                        {
                            while (oSqlDataReader.Read())
                            {
                                Cprb_BoletaBE oCprb_BoletaBE = new Cprb_BoletaBE();
                                oCprb_BoletaBE.f_impTotalBoleta = (double)(oSqlDataReader["f_impTotalBoleta"]);
                                oCprb_BoletaBE.oComprobanteBE.i_idComprobante = (int)(oSqlDataReader["i_idComprobante"]);
                               oListCpr_BoletaBE.Add(oCprb_BoletaBE);
                            }
                            oSqlDataReader.Close();
                        }
                    }
                    conexion.Close();
                    return oListCpr_BoletaBE;
                }
                catch (System.Exception e)
                {

                    return null;
                }
            }
        }




    }
}