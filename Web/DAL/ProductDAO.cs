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
            SqlDataAdapter da = new SqlDataAdapter("Select * from product", conn);
            DataTable dt = new DataTable("product");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Product product)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into product Values(@productName,@productDiscripiton,@price,@categoryID,@shopID)", conn);
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
            SqlCommand cmd = new SqlCommand("Update product Set productName=@productName,productDiscripiton=@productDiscripiton,price=@price,categoryID=@categoryID,shopID=@shopID  where productID = @productID", conn);
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
            SqlCommand cmd = new SqlCommand("Delete product where productID = @productID", conn);
            cmd.Parameters.Add("@productID", product.productID);
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
