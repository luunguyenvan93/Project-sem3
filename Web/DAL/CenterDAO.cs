using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class CenterDAO : ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from center",conn);
            DataTable dt = new DataTable("center");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Center center)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into center Values(@centerName)",conn);
            cmd.Parameters.Add("@centerName",center.centerName);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Center center)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update center Set centerName=@centerName where centerID = @centerID", conn);
            cmd.Parameters.Add("@centerID", center.centerID);
            cmd.Parameters.Add("@centerName", center.centerName);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Center center)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Delete center where centerID = @centerID", conn);
            cmd.Parameters.Add("@centerID", center.centerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
