using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace VKD.BL
{
    public class Album
    {
        public string Name;
        public DateTime YearOfPublishing;
        public IEnumerable<Song> Songs;
        public Image Cover;
    }
}
