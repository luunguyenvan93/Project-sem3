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
            SqlCommand cmd = new SqlCommand("selectFloor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("floor");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Floor floor)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("addFloor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@floorName",floor.floorName);
            cmd.Parameters.Add("@centerID", floor.centerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Floor floor)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("updateFloor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@floorID", floor.floorID);
            cmd.Parameters.Add("@floorName",floor.floorName);
            cmd.Parameters.Add("@centerID", floor.centerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Floor floor)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("deleteFloor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@floorID", floor.floorID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable search(string floorName)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("searchCenter", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@floorName", floorName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}

