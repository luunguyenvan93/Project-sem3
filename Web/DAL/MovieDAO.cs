using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class MovieDAO:ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("selectMovie", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("movie");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Movie movie)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("addMovie", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@movieName", movie.movieName);
            cmd.Parameters.Add("@movieDiscription", movie.movieDiscription);
            cmd.Parameters.Add("@showTime", movie.showTime);
            cmd.Parameters.Add("@movieImage", movie.movieImage);
            cmd.Parameters.Add("@movieImage", movie.movieImage);
            cmd.Parameters.Add("@centerID", movie.centerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Movie movie)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("updateMovie", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@movieID", movie.movieID);
            cmd.Parameters.Add("@movieName", movie.movieName);
            cmd.Parameters.Add("@movieDiscription", movie.movieDiscription);
            cmd.Parameters.Add("@showTime", movie.showTime);
            cmd.Parameters.Add("@movieImage", movie.movieImage);
            cmd.Parameters.Add("@centerID", movie.centerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Movie movie)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("deleteMovie", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@movieID", movie.movieID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable search(string movieName)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("searchMovie", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@movieName", movieName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
