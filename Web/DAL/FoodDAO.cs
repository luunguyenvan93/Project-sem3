using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class FoodDAO:ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from food", conn);
            DataTable dt = new DataTable("food");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Food food)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into food Values(@foodName,@foodDiscription,@foodImage,@price)", conn);
            cmd.Parameters.Add("@foodName", food.foodName);
            cmd.Parameters.Add("@foodDiscription", food.foodDiscription);
            cmd.Parameters.Add("@foodImage", food.foodImage);
            cmd.Parameters.Add("@price", food.price);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Food food)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update food Set foodName=@foodName,foodDiscription = @foodDiscription,foodImage=@foodImage,price=@price where foodID = @foodID", conn);
            cmd.Parameters.Add("@foodID", food.foodID);
            cmd.Parameters.Add("@foodName", food.foodName);
            cmd.Parameters.Add("@foodDiscription", food.foodDiscription);
            cmd.Parameters.Add("@foodImage", food.foodImage);
            cmd.Parameters.Add("@price", food.price);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Food food)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Delete food where foodID = @foodID", conn);
            cmd.Parameters.Add("@fooID", food.foodID);
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
