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
    public class ShopBUS
    {
        ShopDAO shopDAO = null;
        public ShopBUS()
        {
            shopDAO = new ShopDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = shopDAO.getAll();
            return dt;
        }
        public void insert(string shopName, int floorID)
        {
            Shop shop = new Shop();
            shop.shopName = shopName;
            shop._floorID = floorID;
            shopDAO.insert(shop);
        }
        public void update(int shopID, string shopName, int floorID)
        {
            Shop shop = new Shop();
            shop.shopName = shopName;
            shop.floorID = floorID;
            shop.shopID = shopID;
            shopDAO.update(shop);
        }
        public void delete(int shopID)
        {
            Shop shop = new Shop();
            shop.shopID = shopID;
            shopDAO.delete(shop);
        }
        public DataTable search(string shopName)
        {
            DataTable dt = new DataTable();
            dt = shopDAO.search(shopName);
            return dt;
        }
    }
}
