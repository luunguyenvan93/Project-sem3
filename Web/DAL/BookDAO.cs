using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class BookDAO:ConnectionTool
    {
        public DataTable getAll()
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from book", conn);
            DataTable dt = new DataTable("book");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Book book)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Insert Into book Values(@customerID,@BookDate,@status)", conn);
            cmd.Parameters.Add("@customerID", book.customerID);
            cmd.Parameters.Add("@BookDate",book.BookDate);
            cmd.Parameters.Add("@status", book.status);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Book book)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Update book Set customerID=@customerID, BookDate=@BookDate, status=@status where movieID = @movieID", conn);
            cmd.Parameters.Add("@movieID", book.movieID);
            cmd.Parameters.Add("@customerID", book.customerID);
            cmd.Parameters.Add("@BookDate", book.BookDate);
            cmd.Parameters.Add("@status", book.status);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void delete(Book book)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("Delete book where movieID = @movieID", conn);
            cmd.Parameters.Add("@movieID", book.movieID);
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
