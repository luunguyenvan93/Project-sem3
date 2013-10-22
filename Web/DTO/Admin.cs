using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Admin
    {
        public int _id;
        public string _userName;
        public string _password;
        public Boolean _role;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public Boolean role
        {
            get { return _role; }
            set { _role = value; }
        }
    }
}
