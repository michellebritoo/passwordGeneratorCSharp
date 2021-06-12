using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Passwords
{
    public class Connection
    {
        SqlConnection DBcon = new SqlConnection();
        

        public Connection()
        {
            DBcon.ConnectionString = @"Data Source=DESKTOP-NL41TFD\SQLEXPRESS;Initial Catalog=SenhasDB;Integrated Security=True";
        }

        public SqlConnection connect()
        {
            if(DBcon.State == System.Data.ConnectionState.Closed)
                DBcon.Open();
            
            return DBcon;
        }

        public void disconnect()
        {
            if (DBcon.State == System.Data.ConnectionState.Open)
                DBcon.Close();
        }

    }
}
