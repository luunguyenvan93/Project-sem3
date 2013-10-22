using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Floor
    {
        private int _floorID;
        private string _floorName;
        private int _centerID;
        public int floorID
        {
            get { return _floorID; }
            set { _floorID = value; }
        }
        public string floorName
        {
            get { return _floorName; }
            set { _floorName = value; }
        }
        public int  centerID
        {
            get { return _centerID; }
            set { _centerID = value; }
        }
    }
}
