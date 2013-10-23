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
    public class ProductBUS
    {
        ProductDAO productDAO = null;
        public ProductBUS()
        {
            productDAO = new ProductDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = productDAO.getAll();
            return dt;
        }
        public void insert(string productName, string productDiscripiton, float price, int categoryID, int shopID)
        {
            Product product = new Product();
            product.productName = productName;
            product.productDiscripiton = productDiscripiton;
            product.price = price;
            product.categoryID = categoryID;
            product.shopID = shopID;
            productDAO.insert(product);
        }
        public void update(int productID, string productName, string productDiscripiton, float price, int categoryID, int shopID)
        {
            Product product = new Product();
            product.productID = productID;
            product.productName = productName;
            product.productDiscripiton = productDiscripiton;
            product.price = price;
            product.categoryID = categoryID;
            product.shopID = shopID;
            productDAO.update(product);
        }
        public void delete(int productID)
        {
            Product product = new Product();
            product.productID = productID;
            productDAO.delete(product);
        }
        public DataTable search(string productName)
        {
            DataTable dt = new DataTable();
            dt = productDAO.search(productName);
            return dt;
        }
    }
}
