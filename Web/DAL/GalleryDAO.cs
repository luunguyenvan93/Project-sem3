using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class GalleryDAO:ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from gallery", conn);
            DataTable dt = new DataTable("gallery");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Gallery gallery)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into gallery Values(@imageName,@categoryID)", conn);
            cmd.Parameters.Add("@imageName", gallery.imageName);
            cmd.Parameters.Add("@categoryID", gallery.categoryID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Gallery gallery)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update gallery Set imageName=@imageName,categoryID = @categoryID where imageID = @imageID", conn);
            cmd.Parameters.Add("@imageID", gallery.imageID);
            cmd.Parameters.Add("@imageName", gallery.imageName);
            cmd.Parameters.Add("@categoryID", gallery.categoryID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Gallery gallery)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Delete gallery where imageID = @imageID", conn);
            cmd.Parameters.Add("@imageID", gallery.imageID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable loadCmbCenter()
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from gallery", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
