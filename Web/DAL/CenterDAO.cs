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
            SqlCommand cmd = new SqlCommand("selectCenter", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("center");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Center center)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("addCenter",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@centerName",center.centerName);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Center center)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("updateCenter", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@centerID", center.centerID);
            cmd.Parameters.Add("@centerName", center.centerName);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Center center)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("deleteCenter", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@centerID", center.centerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable search(string centerName)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("searchCenter",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@centerName",centerName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
