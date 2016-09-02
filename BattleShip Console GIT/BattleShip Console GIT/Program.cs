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

            //create battlemap
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    GameMap[x, y] = false;
                }
            }

            //DEBUG
            Console.WriteLine("Debug: " + GameMap.GetLength(1)); 


            //create ships
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
            int shots_fired = 0;

            for (int i = 0; i < current_amount_of_bs; i = i)
            {
                Console.WriteLine("Skepapr kvar: " + current_amount_of_bs);
                Console.WriteLine("Mata in X koordinat för kanoner att skjuta: ");
                int inx = int.Parse(Console.ReadLine());
                Console.WriteLine("Mata in Y koordinat för kanoner att skjuta: ");
                int iny = int.Parse(Console.ReadLine());

                if (check_coord(inx, iny))
                {
                    GameMap[inx, iny] = false;
                    Console.Beep(420, 150);
                    Console.WriteLine("Du träffade!");
                    current_amount_of_bs--;
                    Draw_game_map(inx, iny);
                }
                else
                {
                    Console.WriteLine("Du missade!");
                    Draw_game_map(inx, iny);
                }
                shots_fired++;
                Console.WriteLine("Skott avfyrade: " + shots_fired);

            }
            Console.WriteLine("Du vann! Tryck på en knapp för att avsluta programmet.");
            Console.ReadLine();


        }

        //Början på Alekseis metoder
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

        //Mer kod av daniel
        static void Draw_game_map(int Xpos, int Ypos)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (check_coord(j, i))
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
