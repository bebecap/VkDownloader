using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VKD.DAL
{
    class XMLStorage:IStorage
    {
        public IEnumerable<BL.Artist> Load()
        {
            return new List<BL.Artist>();
        }

        public void Save(IEnumerable<BL.Artist> artists)
        {
            throw new NotImplementedException();
        }
    }
}
