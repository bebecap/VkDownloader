using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VKD.BL;

namespace VKD.DAL
{
    interface IStorage
    {
        IEnumerable<Artist> Load();
        void Save(IEnumerable<Artist> artists);
    }
}
