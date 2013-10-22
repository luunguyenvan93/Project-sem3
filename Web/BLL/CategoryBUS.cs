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
    public class CategoryBUS
    {
        CategoryDAO categoryDAO=null;
        public CategoryBUS()
        {
            categoryDAO = new CategoryDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = categoryDAO.getAll();
            return dt;
        }
        public void insert(string categoryName)
        {
            Category category = new Category();
            category.categoryName = categoryName;
            categoryDAO.insert(category);
        }
        public void update(int categoryID, string categoryName)
        {
            Category category = new Category();
            category.categoryID = categoryID;
            category.categoryName = categoryName;
            categoryDAO.update(category);
        }
        public void delete(int categoryID)
        {
            Category category = new Category();
            category.categoryID = categoryID;
            categoryDAO.delete(category);
        }
        public DataTable loadCmbCenter()
        {
            DataTable dt = new DataTable();
            dt = categoryDAO.loadCmbCenter();
            return dt;
        }
    }
}
