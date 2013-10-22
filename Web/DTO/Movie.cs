using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Movie
    {
        public int _movieID;
        public string _movieName;
        public string _movieDiscription;
        public DateTime _showTime;
        public string _movieImage;
        public int movieID
        {
            get { return _movieID; }
            set { _movieID = value; }
        }
        public string movieName
        {
            get { return _movieName; }
            set { _movieName = value; }
        }
        public string movieDiscription
        {
            get { return _movieDiscription; }
            set { _movieDiscription = value; }
        }
        public DateTime showTime
        {
            get { return _showTime; }
            set { _showTime = value; }
        }
        public string movieImage
        {
            get { return _movieImage; }
            set { _movieImage = value; }
        }
    }
}
