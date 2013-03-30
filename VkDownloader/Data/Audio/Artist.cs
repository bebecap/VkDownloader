using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VkDownloader.Data.Audio
{
    class Artist
    {
        public string Name;
        public List<Album> Albums;
        public Artist(string name)
        {
            Name = name;
            Albums = new List<Album>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
