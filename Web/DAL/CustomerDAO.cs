using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class CustomerDAO:ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("selectCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("customer");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Customer customer)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("addCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@customerName", customer.customerName);
            cmd.Parameters.Add("@customerAddress", customer.customerAddress);
            cmd.Parameters.Add("@customerPhone", customer.customerPhone);
            cmd.Parameters.Add("@customerEmail", customer.customerEmail);
            cmd.Parameters.Add("@customerGender", customer.customerGender);
            cmd.Parameters.Add("@customerBirthday", customer.customerBirthday);
            cmd.Parameters.Add("@customerCard", customer.customerCard);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Customer customer)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("updateCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@customerID", customer.customerID);
            cmd.Parameters.Add("@customerName", customer.customerName);
            cmd.Parameters.Add("@customerAddress", customer.customerAddress);
            cmd.Parameters.Add("@customerPhone", customer.customerPhone);
            cmd.Parameters.Add("@customerEmail", customer.customerEmail);
            cmd.Parameters.Add("@customerGender", customer.customerGender);
            cmd.Parameters.Add("@customerBirthday", customer.customerBirthday);
            cmd.Parameters.Add("@customerCard", customer.customerCard);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Customer customer)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("deleteCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@customerID", customer.customerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable search(string customerName)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("searchCustomer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@customerName", customerName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
