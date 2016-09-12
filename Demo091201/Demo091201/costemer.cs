using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo091201
{
    class costemer
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        public string Fullname()
        {
            return string.Format("{0} {1}", firstname, lastname);
        }
    }
}
