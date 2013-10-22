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
    public class AdminBUS
    {
        AdminDAO adminDAO = null;
        public AdminBUS()
        {
            adminDAO = new AdminDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = adminDAO.getAll();
            return dt;
        }
        public void insert(string userName, string password, Boolean role)
        {
            Admin admin = new Admin();
            admin.userName = userName;
            admin.password = password;
            admin.role = role;
            adminDAO.insert(admin);
        }
        public void update(int id, string userName, string password, Boolean role)
        {
            Admin admin = new Admin();
            admin.id = id;
            admin.userName = userName;
            admin.password = password;
            admin.role = role;
            adminDAO.update(admin);
        }
        public void delete(int id)
        {
            Admin admin = new Admin();
            admin.id = id;
            adminDAO.delete(admin);
        }
        public DataTable loadCmbCenter()
        {
            DataTable dt = new DataTable();
            dt = adminDAO.loadCmbCenter();
            return dt;
        }
    }
}
