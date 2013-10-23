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
    public class CustomerBUS
    {
        CustomerDAO customerDAO = null;
        public CustomerBUS()
        {
            customerDAO = new CustomerDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = customerDAO.getAll();
            return dt;
        }
        public void insert(string customerName, string customerAddress, string customerPhone, string customerEmail, Boolean customerGender, DateTime customerBirthday, string customerCard)
        {
            Customer customer = new Customer();
            customer.customerName = customerName;
            customer.customerAddress = customerAddress;
            customer.customerPhone = customerPhone;
            customer.customerEmail = customerEmail;
            customer.customerGender = customerGender;
            customer.customerBirthday = customerBirthday;
            customer.customerCard = customerCard;
            customerDAO.insert(customer);
        }
        public void update(int customerID,string customerName, string customerAddress, string customerPhone, string customerEmail, Boolean customerGender, DateTime customerBirthday, string customerCard)
        {
            Customer customer = new Customer();
            customer.customerID = customerID;
            customer.customerName = customerName;
            customer.customerAddress = customerAddress;
            customer.customerPhone = customerPhone;
            customer.customerEmail = customerEmail;
            customer.customerGender = customerGender;
            customer.customerBirthday = customerBirthday;
            customer.customerCard = customerCard;
            customerDAO.update(customer);
        }
        public void delete(int customerID)
        {
            Customer customer = new Customer();
            customer.customerID = customerID;
            customerDAO.delete(customer);
        }
        public DataTable search(string customerName)
        {
            DataTable dt = new DataTable();
            dt = foodDAO.search(customerName);
            return dt;
        }
    }
}
