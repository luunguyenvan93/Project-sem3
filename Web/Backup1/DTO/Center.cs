using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Center
    {
        private int _centerID;
        private string _centerName;
        public int centerID
        {
            get { return _centerID; }
            set { _centerID = value; }
        }
        public string centerName
        {
            get { return _centerName; }
            set { _centerName = value; }
        }

    }
}
