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
            SqlCommand cmd = new SqlCommand("selectFood", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("food");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Food food)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("addFood", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@foodName", food.foodName);
            cmd.Parameters.Add("@foodDiscription", food.foodDiscription);
            cmd.Parameters.Add("@foodImage", food.foodImage);
            cmd.Parameters.Add("@price", food.price);
            cmd.Parameters.Add("@centerID", food.centerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Food food)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("updateFood", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@foodID", food.foodID);
            cmd.Parameters.Add("@foodName", food.foodName);
            cmd.Parameters.Add("@foodDiscription", food.foodDiscription);
            cmd.Parameters.Add("@foodImage", food.foodImage);
            cmd.Parameters.Add("@price", food.price);
            cmd.Parameters.Add("@centerID", food.centerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Food food)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("deleteFood", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@foodID", food.foodID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable search(string foodName)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("searchFood", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@foodName", foodName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
