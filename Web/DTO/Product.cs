using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Product
    {
        private int _productID;
        public string _productName;
        public string _productDiscripiton;
        public float _price;
        public int _categoryID;
        public int _shopID;
        public int productID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        public string productName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public string productDiscripiton
        {
            get { return _productDiscripiton; }
            set { _productDiscripiton = value; }
        }
        public float price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int categoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }
        public int shopID
        {
            get { return _shopID; }
            set { _shopID = value; }
        }

    }
}
