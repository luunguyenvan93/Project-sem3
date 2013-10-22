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
    public class MovieBUS
    {
        MovieDAO movieDAO = null;
        public MovieBUS()
        {
            movieDAO = new MovieDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = movieDAO.getAll();
            return dt;
        }
        public void insert(string movieName, string movieDiscription, DateTime showTime, string movieImage)
        {
            Movie movie = new Movie();
            movie.movieName = movieName;
            movie.movieDiscription = movieDiscription;
            movie.showTime = showTime;
            movie.movieImage = movieImage;
            movieDAO.insert(movie);
        }
        public void update(int movieID, string movieName, string movieDiscription, DateTime showTime, string movieImage)
        {
            Movie movie = new Movie();
            movie.movieID = movieID;
            movie.movieName = movieName;
            movie.movieDiscription = movieDiscription;
            movie.showTime = showTime;
            movie.movieImage = movieImage;
            movieDAO.update(movie);
        }
        public void delete(int movieID)
        {
            Movie movie = new Movie();
            movie.movieID = movieID;
            movieDAO.delete(movie);
        }
        public DataTable loadCmbCenter()
        {
            DataTable dt = new DataTable();
            dt = movieDAO.loadCmbCenter();
            return dt;
        }
    }
}
