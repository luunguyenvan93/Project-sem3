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
   public class FloorBUS
    {
        FloorDAO floorDAO = null;
        public  FloorBUS()
        {
             floorDAO = new FloorDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = floorDAO.getAll();
            return dt;
        }
        public void insert(string floorName,int centerID)
        {
            Floor floor = new Floor();
            floor.floorName = floorName;
            floor.centerID = centerID;
            floorDAO.insert(floor);
        }
        public void update(int floorID,string floorName,int centerID)
        {
            Floor floor = new Floor();
            floor.floorID = floorID;
            floor.floorName = floorName;
            floor.centerID = centerID;
            floorDAO.update(floor);
        }
        public void delete(int floorID)
        {
            Floor floor = new Floor();
            floor.floorID = floorID;
            floorDAO.delete(floor);
        }
        public DataTable search(string floorName)
        {
            DataTable dt = new DataTable();
            dt = floorDAO.search(floorName);
            return dt;
        }
    }
}
