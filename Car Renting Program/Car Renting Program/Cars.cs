using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting_Program
{
    class Cars
    {
        public string Maker { get; set; }
        public string RegristerNumber { get; set; }
        public string Color { get; set; }
        public Boolean Rented { get; set; }

        public string CarName()
        {
            return string.Format("{0} {1}", Maker, RegristerNumber);
        }
    }
}
