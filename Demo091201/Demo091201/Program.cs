using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo091201
{
    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            c.Color = "red";

            car d;
            d = c;
            d.Color = "blue";



            Console.WriteLine("bilens färg är: " + c.Color);
            Console.WriteLine("bilens färg är: " + d.Color);


            costemer mycostemer = new costemer();
            mycostemer.firstname = "kalle";
            mycostemer.lastname = "anka";

            Console.WriteLine(mycostemer.Fullname());
        }

        public class car
        {
            public string Regrestationnumber { get; set; }

            public string Make { get; set; }

            public string Model { get; set; }

            public string Color { get; set; }
        }
    }
}
