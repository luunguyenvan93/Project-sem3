using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class ProductDAO:ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("selectProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("product");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Product product)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("addProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@productName", product.productName);
            cmd.Parameters.Add("@productDiscripiton", product.productDiscripiton);
            cmd.Parameters.Add("@price", product.price);
            cmd.Parameters.Add("@categoryID", product.categoryID);
            cmd.Parameters.Add("@shopID", product.shopID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Product product)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("updateProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@productName", product.productName);
            cmd.Parameters.Add("@productDiscripiton", product.productDiscripiton);
            cmd.Parameters.Add("@price", product.price);
            cmd.Parameters.Add("@categoryID", product.categoryID);
            cmd.Parameters.Add("@shopID", product.shopID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Product product)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("deleteProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@productID", product.productID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable search(string productName)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("searchProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
