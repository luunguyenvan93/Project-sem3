using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class AdminDAO:ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from admin", conn);
            DataTable dt = new DataTable("admin");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Admin admin)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into admin Values(@userName,@userName,@role)", conn);
            cmd.Parameters.Add("@userName", admin.userName);
            cmd.Parameters.Add("@password", admin.password);
            cmd.Parameters.Add("@role", admin.role);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Admin admin)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update admin Set userName=@userName,userName = @userName, role=@role where id = @id", conn);
            cmd.Parameters.Add("@id", admin.id);
            cmd.Parameters.Add("@userName", admin.userName);
            cmd.Parameters.Add("@password", admin.password);
            cmd.Parameters.Add("@role", admin.role);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Admin admin)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Delete admin where id = @id", conn);
            cmd.Parameters.Add("@id", admin.id);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable loadCmbCenter()
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from center", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
