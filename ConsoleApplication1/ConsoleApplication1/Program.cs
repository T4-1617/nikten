using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in det första numret");
            string first = Console.ReadLine();
            Console.WriteLine("skriv in det andra numret");
            string second = Console.ReadLine();
            Console.WriteLine("skriv +, -, / eller *");
            string type = Console.ReadLine();

            int firstInt;
            int secondInt;
            int awnser;
            string tell = "";
            int.TryParse(first, out firstInt);
            int.TryParse(second, out secondInt);

            switch (type)
            {
                case "+":
                    awnser = firstInt + secondInt;
                    tell = first + " + " + second + " = " + awnser;
                    break;
                case "-":
                    awnser = firstInt - secondInt;
                    tell = first + " - " + second + " = " + awnser;
                    break;
                case "/":
                    awnser = firstInt / secondInt;
                    tell = first + " / " + second + " = " + awnser;
                    break;
                case "*":
                    awnser = firstInt * secondInt;
                    tell = first + " * " + second + " = " + awnser;
                    break;
            }

            Console.WriteLine(tell);
            Console.ReadLine();
        }
    }
}
