using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_namn_uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            long amount = 0;
            string name = string.Empty;

            Console.WriteLine("skriv in ditt för och efter namn här");
            name = Console.ReadLine();
            Console.WriteLine("2.1: Antalet bokstäver inklusive mellanslag: " + name.Length);
            foreach (int item in name)
            {
                if (item != ' ')
                    amount++;
            }
            Console.WriteLine("2.2: Antal bokstäver utan mellanslag är " + amount);

            
            int amount_before_space = name.IndexOf(' ');
            Console.WriteLine("2.3: Förnamnet är " + amount_before_space + " bokstäver lång");
            for (int i = 0; i < amount_before_space; i++)
            {
                Console.Write(name[i]); // prints first name

            }
            Console.WriteLine("");
            Console.WriteLine("2.4: Efternamnet är " + (amount - amount_before_space) + " bokstäver lång");


            Console.WriteLine(name.Substring(name.IndexOf(' ')+1)); //prints last name

            Console.Write("2.5: " + name.Substring(name.IndexOf(' ') + 1) + ", ");
            for (int i = 0; i < amount_before_space; i++)
            {
                Console.Write(name[i]); // prints first name

            }
            Console.WriteLine("");

            for (int i = 0; i < amount_before_space; i++)
            {
                Console.WriteLine("----->" + name[i]);
            }
            for (int i = amount_before_space + 1; i < name.Length; i++)
            {
                Console.WriteLine(("------->" + name[i]));

            }



            //PRINT BACKWARDS MLC
            string reverse = string.Empty;
            for (int i = name.Length - 1; i > -1; i--)
            {
                reverse += name[i];
            }
            Console.WriteLine("Namnet baklänges: " + reverse);



            Console.WriteLine("2.8: ");
            string lowcase = name.ToLower();
           

            for (int i = 0; i < lowcase.Length; i++)
            {
                if (i % 2 != 0)
                    Console.Write(lowcase[i].ToString().ToUpper());
                else
                    Console.Write(lowcase[i]);
            }

            Console.WriteLine("");



            string h4xx0r = string.Empty;

            
            Console.WriteLine("2.9: ");
            for (int i = 0; i < name.Length; i++)
            {
                switch (lowcase[i])
                {
                    case ('a'):
                        Console.Write("4");
                        break;
                    case ('b'):
                        Console.Write("6");
                        break;
                    case ('c'):
                        Console.Write("<");
                        break;
                    case ('d'):
                        Console.Write("[)");
                        break;
                    case ('e'):
                        Console.Write("[-");
                        break;
                    case ('f'):
                        Console.Write("/=");
                        break;
                    case ('g'):
                        Console.Write("gee");
                        break;
                    case ('h'):
                        Console.Write("}{");
                        break;
                    case ('i'):
                        Console.Write("1");
                        break;
                    case ('j'):
                        Console.Write("_/");
                        break;
                    case ('k'):
                        Console.Write("|<");
                        break;
                    case ('l'):
                        Console.Write("|_");
                        break;
                    case ('m'):
                        Console.Write("^^");
                        break;
                    case ('n'):
                        Console.Write("/\\/");
                        break;
                    case ('o'):
                        Console.Write("0");
                        break;
                    case ('p'):
                        Console.Write("|>");
                        break;
                    case ('q'):
                        Console.Write("()_");
                        break;
                    case ('r'):
                        Console.Write("|^");
                        break;
                    case ('s'):
                        Console.Write("$");
                        break;
                    case ('t'):
                        Console.Write("7");
                        break;
                    case ('v'):
                        Console.Write("\\/");
                        break;
                    case ('w'):
                        Console.Write("\\^/");
                        break;
                    case ('x'):
                        Console.Write("><");
                        break;
                    case ('y'):
                        Console.Write("'/");
                        break;
                    case ('z'):
                        Console.Write("2");
                        break;
                     default:
                        Console.Write("_");
                        break;
                }

                
            }

            Console.ReadLine();

        }
    }
}
