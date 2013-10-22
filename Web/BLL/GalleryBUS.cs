using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;
namespace BLL
{
    public class GalleryBUS
    {
        GalleryDAO galleryDAO = null;
        public GalleryBUS()
        {
            galleryDAO = new GalleryDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = galleryDAO.getAll();
            return dt;
        }
        public void insert(string imageName, int categoryID)
        {
            Gallery gallery = new Gallery();
            gallery.imageName = imageName;
            gallery.categoryID = categoryID;
            galleryDAO.insert(gallery);
        }
        public void update(int imageID, string imageName, int categoryID)
        {
            Gallery gallery = new Gallery();
            gallery.imageID = imageID;
            gallery.imageName = imageName;
            gallery.categoryID = categoryID;
            galleryDAO.update(gallery);
        }
        public void delete(int imageID)
        {
            Gallery gallery = new Gallery();
            gallery.imageID = imageID;
            galleryDAO.delete(gallery);
        }
        public DataTable loadCmbCenter()
        {
            DataTable dt = new DataTable();
            dt = galleryDAO.loadCmbCenter();
            return dt;
        }
    }
}
