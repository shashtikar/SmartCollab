using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace SmartCollab
{
    public class dataConn
    {
        public SqlConnection conn = new SqlConnection();
        
        public void setUpConnection()
        {
            conn.ConnectionString = "Data Source=SHASHANK-PC;Initial Catalog=master;Integrated Security=True";
            SqlCommand qry = new SqlCommand();
            qry.CommandText = "Select * from ";
            qry.CommandType = System.Data.CommandType.Text;

        }
    }
}