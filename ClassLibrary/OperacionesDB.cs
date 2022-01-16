using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class OperacionesDB
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataAdapter adaptador;

        public OperacionesDB()
        {
            string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            conexion.ConnectionString = connStr;
        }
    }
}
