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
            SqlDataAdapter da = new SqlDataAdapter("Select * from shop", conn);
            DataTable dt = new DataTable("shop");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Shop shop)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into shop Values(@shopName,@floorID)", conn);
            cmd.Parameters.Add("@shopName", shop.shopName);
            cmd.Parameters.Add("@floorID", shop.floorID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Shop shop)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update shop Set shopName=@shopName,floorID = @floorID where floorID = @floorID", conn);
            cmd.Parameters.Add("@shopID", shop.shopID);
            cmd.Parameters.Add("@shopName", shop.shopName);
            cmd.Parameters.Add("@floorID", shop.floorID);       
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Shop shop)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Delete shop where shopID = @shopID", conn);
            cmd.Parameters.Add("@shopID", shop.shopID);
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
