using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class CategoryDAO:ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("selectCategory", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("category");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Category category)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("addCategory", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@categoryName", category.categoryName);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Category category)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("updateCategory", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@categoryID", category.categoryID);
            cmd.Parameters.Add("@categoryName", category.categoryName);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Category category)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("deleteCategory", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@categoryID", category.categoryID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable search(string categoryName)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("searchCategory", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@categoryName", categoryName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
