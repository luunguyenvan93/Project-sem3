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
            SqlCommand cmd = new SqlCommand("selectBook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("book");
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void insert(Book book)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("addBook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@movieID", book.movieID);
            cmd.Parameters.Add("@customerID", book.customerID);
            cmd.Parameters.Add("@BookDate",book.BookDate);
            cmd.Parameters.Add("@status", book.status);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void update(Book book)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("updateBook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
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
            SSqlCommand cmd = new SqlCommand("deleteBook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@movieID", book.movieID);
            cmd.Parameters.Add("@customerID", book.customerID);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable search(int movieID, int customerID)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("searchBook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@movieID", movieID);
            cmd.Parameters.Add("@customerID", customerID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
