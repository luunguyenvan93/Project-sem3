using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Book
    {
        public int _movieID;
        public int _customerID;
        public DateTime _BookDate;
        public int _status;
        public int movieID
        {
            get { return _movieID; }
            set { _movieID = value; }
        }
        public int customerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public DateTime BookDate
        {
            get { return _BookDate; }
            set { _BookDate = value; }
        }
        public int status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
