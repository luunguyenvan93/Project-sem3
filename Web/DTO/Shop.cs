using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Shop
    {
        private int _shopID;
        private string _shopName;
        public int _floorID;
        public int shopID
        {
            get { return _shopID; }
            set { _shopID = value; }
        }
        public string shopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }
        public int floorID
        {
            get { return _floorID; }
            set { _floorID = value; }
        }
    }
}
