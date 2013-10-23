using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Customer
    {
        public int _customerID;
        public string _customerName;
        public string _customerAddress;
        public string _customerPhone;
        public string _customerEmail;
        public Boolean _customerGender;
        public DateTime _customerBirthday;
        public string _customerCard;
        public int customerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public string customerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        public string customerAddress
        {
            get { return _customerAddress; }
            set { _customerAddress = value; }
        }
        public string customerPhone
        {
            get { return _customerPhone; }
            set { _customerPhone = value; }
        }
        public string customerEmail
        {
            get { return _customerEmail; }
            set { _customerEmail = value; }
        }
        public Boolean customerGender
        {
            get { return _customerGender; }
            set { _customerGender = value; }
        }
        public DateTime customerBirthday
        {
            get { return _customerBirthday; }
            set { _customerBirthday = value; }
        }
        public string customerCard
        {
            get { return _customerCard; }
            set { _customerCard = value; }
        }
    }
}
