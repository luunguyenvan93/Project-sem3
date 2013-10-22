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
            SqlDataAdapter da = new SqlDataAdapter("Select * from movie", conn);
            DataTable dt = new DataTable("movie");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Movie movie)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into movie Values(@movieName,@movieDiscription,@showTime,@movieImage)", conn);
            cmd.Parameters.Add("@movieName", movie.movieName);
            cmd.Parameters.Add("@movieDiscription", movie.movieDiscription);
            cmd.Parameters.Add("@showTime", movie.showTime);
            cmd.Parameters.Add("@movieImage", movie.movieImage);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Movie movie)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update movie Set movieName=@movieName, movieDiscription=@movieDiscription, showTime=@showTime, movieImage=@movieImage where movieID = @movieID", conn);
            cmd.Parameters.Add("@movieID", movie.movieID);
            cmd.Parameters.Add("@movieName", movie.movieName);
            cmd.Parameters.Add("@movieDiscription", movie.movieDiscription);
            cmd.Parameters.Add("@showTime", movie.showTime);
            cmd.Parameters.Add("@movieImage", movie.movieImage);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Movie movie)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Delete movie where movieID = @movieID", conn);
            cmd.Parameters.Add("@movieID", movie.movieID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable loadCmbCenter()
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from movie", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
