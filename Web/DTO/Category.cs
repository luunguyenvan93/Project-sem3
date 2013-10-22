using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Category
    {
        public int _categoryID;
        public string _categoryName;
        public int categoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }
        public string categoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }
    }
}
