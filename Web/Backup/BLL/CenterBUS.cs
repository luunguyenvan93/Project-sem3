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
        public void CenterBUS()
        {
             centerDAO = new CenterDAO();
        }
        public void insert(string centerName)
        {
            Center center = new Center();
            center.centerName = centerName;
        }
    }
}
