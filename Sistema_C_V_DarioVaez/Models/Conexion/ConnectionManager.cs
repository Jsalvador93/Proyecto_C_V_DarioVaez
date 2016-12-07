using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Sistema_C_V_DarioVaez.Models.Conexion
{
    public class ConnectionManager
    {
        public static SqlConnection GetConnection()
        {
            string lStrCadConex = ConfigurationManager.ConnectionStrings["cnnC_V_DarioVaez"].ConnectionString;
            SqlConnection connection = new SqlConnection(lStrCadConex);
            return connection;
        }
    }
}