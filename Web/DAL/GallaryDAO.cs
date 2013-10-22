using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class GallaryDAO:ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from gallary", conn);
            DataTable dt = new DataTable("gallary");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Gallary gallary)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into gallary Values(@imageName,@categoryID)", conn);
            cmd.Parameters.Add("@imageName", gallary.imageName);
            cmd.Parameters.Add("@categoryID", gallary.categoryID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Gallary gallary)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update gallary Set imageName=@imageName,categoryID = @categoryID where imageID = @imageID", conn);
            cmd.Parameters.Add("@imageID", gallary.imageID);
            cmd.Parameters.Add("@imageName", gallary.imageName);
            cmd.Parameters.Add("@categoryID",gallary.categoryID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Gallary gallary)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Delete gallary where imageID = @imageID", conn);
            cmd.Parameters.Add("@imageID", gallary.imageID);
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
