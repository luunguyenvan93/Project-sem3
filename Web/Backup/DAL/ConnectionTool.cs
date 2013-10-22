using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    class ConnectionTool
    {
        public SqlConnection conn = new SqlConnection("Server=LUU-PC;Database=MallManagement;UID=sa;PWD=1234$");
        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close() ;
            }
        }
    }
}
