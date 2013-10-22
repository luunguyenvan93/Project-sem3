using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class CenterDAO:ConnectionTool
    {
        public void insert(Center center)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into center Values(@centerName)",conn);
            cmd.Parameters.Add("@centerName",center.centerName);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
