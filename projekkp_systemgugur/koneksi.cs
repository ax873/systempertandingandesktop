using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace projekkp_systemgugur
{
    class koneksi
    {
          public SqlConnection Getconn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=LAPTOP-BCLI4CKG\\SQLEXPRESS;Initial Catalog=dbsistem;Integrated Security=True";
            return conn;
        } 

    }
}
