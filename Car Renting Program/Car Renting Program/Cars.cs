using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting_Program
{
    public class Car
    {
        public string Maker { get; set; }
        public string RegristerNumber { get; set; }
        public string Color { get; set; }
        public string Modle { get; set; }
        public bool Rented { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Maker, RegristerNumber);
        }
    }
}
