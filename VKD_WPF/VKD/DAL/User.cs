using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VKD.DAL
{
    class User
    {
        public string FirstName;
        public string LastName;
        public int ID;
        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
}
