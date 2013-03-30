using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VkDownloader.Data.Audio
{
    class Album
    {
        public string Name;
        public List<Song> Songs;
        public Album(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }
    }
}
