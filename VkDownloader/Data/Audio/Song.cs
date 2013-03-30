using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VkDownloader.Data.Audio
{
    class Song
    {
        public string Name;
        public string FilePath;
        public Song(string name, string filePath)
        {
            Name = name;
            FilePath = filePath;
        }
    }
}
