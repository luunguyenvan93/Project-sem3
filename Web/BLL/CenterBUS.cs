using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class CenterBUS
    {
        CenterDAO centerDAO = null;
        public  CenterBUS()
        {
             centerDAO = new CenterDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = centerDAO.getAll();
            return dt;
        }
        public void insert(string centerName)
        {
            Center center = new Center();
            center.centerName = centerName;
            centerDAO.insert(center);
        }
        public void update(int centerID,string centerName)
        {
            Center center = new Center();
            center.centerID = centerID;
            center.centerName = centerName;
            centerDAO.update(center);
        }
        public void delete(int centerID)
        {
            Center center = new Center();
            center.centerID = centerID;
            centerDAO.delete(center);
        }
        public DataTable search(string centerName)
        {
            DataTable dt = new DataTable();
            dt = centerDAO.search(centerName);
            return dt;
        }
    }
}
