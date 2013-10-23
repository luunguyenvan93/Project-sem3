using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class ShopDAO:ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("selectShop", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("shop");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Shop shop)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("addShop", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("(@shopName ", shop.shopName);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Shop shop)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("updateShop", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@shopID", shop.shopID);
            cmd.Parameters.Add("@shopName", shop.shopName);
            cmd.Parameters.Add("@floorID", shop.floorID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Shop shop)
        {
            SqlCommand cmd = new SqlCommand("deleteShop", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@shopID", shop.shopID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable search(string shopName)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("searchShop", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@shopName", shopName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
