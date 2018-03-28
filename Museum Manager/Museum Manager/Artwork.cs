using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum_Manager
{
    public class Artwork
    {
        public string Name { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }
        public string Path { get; set; }

        public Artwork(string _name, string _artistname, int _year, string _path)
        {
            Name = _name;
            ArtistName = _artistname;
            Year = _year;
            Path = _path;
        }
    }
}
