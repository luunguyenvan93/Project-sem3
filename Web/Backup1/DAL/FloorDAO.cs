using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
   public class FloorDAO:ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from floor", conn);
            DataTable dt = new DataTable("floor");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Floor floor)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into floor Values(@floorName,@centerID)", conn);
            cmd.Parameters.Add("@floorName",floor.floorName);
            cmd.Parameters.Add("@centerID", floor.centerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Floor floor)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update floor Set floorName=@floorName,centerID = @centerID where floorID = @floorID", conn);
            cmd.Parameters.Add("@floorID", floor.floorID);
            cmd.Parameters.Add("@floorName",floor.floorName);
            cmd.Parameters.Add("@centerID", floor.centerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Floor floor)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Delete floor where floorID = @floorID", conn);
            cmd.Parameters.Add("@floorID", floor.floorID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable loadCmbCenter()
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from center",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}

