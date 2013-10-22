using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Food
    {
        public int _foodID;
        public string _foodName;
        public string _foodDiscription;
        public string _foodImage;
        public double _price;
        public int foodID
        {
            get { return _foodID; }
            set { _foodID = value; }
        }
        public string foodName
        {
            get { return _foodName; }
            set { _foodName = value; }
        }
        public string foodDiscription
        {
            get { return _foodDiscription; }
            set { _foodDiscription = value; }
        }
        public string foodImage
        {
            get { return _foodImage; }
            set { _foodImage = value; }
        }
        public double price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
