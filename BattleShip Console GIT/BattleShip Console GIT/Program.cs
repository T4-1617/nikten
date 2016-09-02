using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship_console
{
    class Program
    {
        //början på daniels kod
        static bool[,] GameMap = new bool[7, 5]; //Game field

        static void Main(string[] args)
        {


            /* SPELET FÖRBEREDDS
             * 
             * 
             */
            Random r = new Random();
            int random_amount_of_bs = r.Next(3, 6); //BS = battleships

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    GameMap[x, y] = false;
                }
            }

            for (int i = 0; i < random_amount_of_bs; i++)
            {
                int Xpos = r.Next(0, 6);
                int Ypos = r.Next(0, 4);
                if (check_coord(Xpos, Ypos) != true) //Calls Check_coord if a cordinate is empty
                {
                    GameMap[Xpos, Ypos] = true;
                }
                Console.WriteLine(i.ToString());
            }


            /* SPELET BÖRJAR
            * 
            *  ALEKSEIS KOD
            */

            int current_amount_of_bs = random_amount_of_bs;

            for (int i = 0; i < current_amount_of_bs; i = i)
            {
                Console.WriteLine("Skepapr kvar: " + current_amount_of_bs);
                Console.ReadLine();
            }
            Console.ReadLine();

        }
        //Slut på daniels kod

        //Början på Alekseis kod
        static bool check_coord(int x, int y) //
        {
            if (GameMap[x, y] == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Slut på Alekseis kod
    }
}
