using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Gallary
    {
        public int _imageID;
        public string _imageName;
        public int _categoryID;
        public int imageID
        {
            get { return _imageID; }
            set { _imageID = value; }
        }
        public string imageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }
        public int categoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }
    }
}
