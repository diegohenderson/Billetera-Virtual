using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Billetera.Web.Models
{
    public class GestorLogin
    {
        public bool ValidarLogin(LoginRequest ploginRequest)
        {
            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();
            bool result = false;
            using(SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("obtener_Login", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@nombre_usuario", ploginRequest.Username));
                comm.Parameters.Add(new SqlParameter("@password", ploginRequest.Password));
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
                return result;
            }
        }
    }
}