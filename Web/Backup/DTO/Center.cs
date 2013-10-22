using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Center
    {
        private int _centerID;
        private string _ceterName;
        public int centerID
        {
            get { return _centerID; }
            set { _centerID = value; }
        }

        public string centerName
        {
            get { return _ceterName; }
            set { _ceterName = value; }
        }
    }
}
