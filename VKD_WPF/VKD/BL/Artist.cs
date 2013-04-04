using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VKD.BL
{
    public class Artist
    {
        public string Name;
        public IEnumerable<Album> Albums;
    }
}
