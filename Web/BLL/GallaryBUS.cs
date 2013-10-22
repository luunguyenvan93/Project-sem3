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
    public class GallaryBUS
    {
        GallaryDAO gallaryDAO = null;
        public GallaryBUS()
        {
            gallaryDAO = new GallaryDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = gallaryDAO.getAll();
            return dt;
        }
        public void insert(string imageName, int categoryID)
        {
            Gallary gallary = new Gallary();
            gallary.imageName = imageName;
            gallary.categoryID = categoryID;
            gallaryDAO.insert(gallary);
        }
        public void update( int imageID, string imageName, int categoryID)
        {
            Gallary gallary = new Gallary();
            gallary.imageID = imageID;
            gallary.imageName = imageName;
            gallary.categoryID = categoryID;
            gallaryDAO.update(gallary);
        }
        public void delete(int imageID)
        {
            Gallary gallary = new Gallary();
            gallary.imageID = imageID;
            gallaryDAO.delete(gallary);
        }
        public DataTable loadCmbCenter()
        {
            DataTable dt = new DataTable();
            dt = gallaryDAO.loadCmbCenter();
            return dt;
        }
    }
}
