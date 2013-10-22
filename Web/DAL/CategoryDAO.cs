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
            SqlDataAdapter da = new SqlDataAdapter("Select * from category", conn);
            DataTable dt = new DataTable("category");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Category category)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into category Values(@categoryName)", conn);
            cmd.Parameters.Add("@categoryName", category.categoryName);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Category category)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update category Set categoryName=@categoryName where categoryID = @categoryID", conn);
            cmd.Parameters.Add("@categoryID", category.categoryID);
            cmd.Parameters.Add("@categoryName", category.categoryName);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Category category)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Delete category where categoryID = @categoryID", conn);
            cmd.Parameters.Add("@categoryID", category.categoryID);
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
