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
    public class FoodBUS
    {
        FoodDAO foodDAO = null;
        public FoodBUS()
        {
            foodDAO = new FoodDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = foodDAO.getAll();
            return dt;
        }
        public void insert(string foodName, string foodDiscription, string foodImage, double price, int centerID)
        {
            Food food = new Food();
            food.foodName = foodName;
            food.foodDiscription = foodDiscription;
            food.foodImage = foodImage;
            food.price = price;
            food.centerID = centerID;
            foodDAO.insert(food);
        }
        public void update(int foodID, string foodName, string foodDiscription, string foodImage, double price)
        {
            Food food = new Food();
            food.foodID = foodID;
            food.foodName = foodName;
            food.foodDiscription = foodDiscription;
            food.foodImage = foodImage;
            food.price = price;
            foodDAO.update(food);
        }
        public void delete(int foodID)
        {
            Food food = new Food();
            food.foodID = foodID;
            foodDAO.delete(food);
        }
        public DataTable search(string foodName)
        {
            DataTable dt = new DataTable();
            dt = foodDAO.search(foodName);
            return dt;
        }
    }
}
