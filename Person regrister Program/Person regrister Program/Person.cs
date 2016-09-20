using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_regrister_Program
{
    public class Costemer : Person
    {
        public int CustemerID { get; set; }
    }

    public class Emplooye : Person
    {
        public int EmplooyeID { get; set; }
        public string Pay { get; set; }
    }

    public class Deliverer : Person
    {
        public string ContactPerson { get; set; }
        public string Company { get; set; }
    }

    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telefone { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);

        }
    }
}
