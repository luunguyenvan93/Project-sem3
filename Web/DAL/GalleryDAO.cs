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
            SqlCommand cmd = new SqlCommand("selectGallery", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable("gallery");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Gallery gallery)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("addGallery", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@imageName", gallery.imageName);
            cmd.Parameters.Add("@categoryID", gallery.categoryID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Gallery gallery)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("updateGallery", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@imageID", gallery.imageID);
            cmd.Parameters.Add("@imageName", gallery.imageName);
            cmd.Parameters.Add("@categoryID", gallery.categoryID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Gallery gallery)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("deleteGallery", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@imageID", gallery.imageID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable search(string imageName)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("searchGallery", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@imageName", imageName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
