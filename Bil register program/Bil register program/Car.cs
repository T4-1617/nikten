using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_register_program
{
    class Car
    {
        public string RegristerNumber { get; set; }
        public string Car_Maker { get; set; }
        public string Gas_type { get; set; }

        public string Car_name()
        {
            return string.Format("{0} {1}", Car_Maker, RegristerNumber);
        }
    }
}
