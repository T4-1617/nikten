using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekt_uppgift
{ 
        public class Costumer
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int idnumer { get; set; }
            public Boolean Archive { get; set; }

            public string Fullname()
            {
                return string.Format("{0} {1}", Firstname, Lastname);
            }
        }
}
