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
    public class BookBUS
    {
        BookDAO bookDAO = null;
        public BookBUS()
        {
            bookDAO = new BookDAO();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            dt = bookDAO.getAll();
            return dt;
        }
        public void insert(int customerID, DateTime BookDate, int status)
        {
            Book book = new Book();
            book.customerID = customerID;
            book.BookDate = BookDate;
            book.status = status;
            bookDAO.insert(book);
        }
        public void update(int movieID,int customerID, DateTime BookDate, int status)
        {
            Book book = new Book();
            book.movieID = movieID;
            book.customerID = customerID;
            book.BookDate = BookDate;
            book.status = status;
            bookDAO.update(book);
        }
        public void delete(int movieID)
        {
            Book book = new Book();
            book.movieID = movieID;
            bookDAO.delete(book);
        }
        public DataTable loadCmbCenter()
        {
            DataTable dt = new DataTable();
            dt = bookDAO.loadCmbCenter();
            return dt;
        }
    }
}
