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
        static int[,] GameMap = new int[7, 5]; //Game field
        //DOCUMENTING
        /* 0 - nothing (never shot there) - displays as 0
         * 1 - living ship - never displayed
         * 2 - dead ship - displayed as X
         * -1 - miss - displayed as .
         */

        static bool no_valid_input = true;
        static int inx = 0;
        static int iny = 0;

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
                    GameMap[x, y] = 0;
                }
            }

            //DEBUG



            //create ships
            for (int i = 0; i < random_amount_of_bs; i++)
            {
                int Xpos = r.Next(0, 6);
                int Ypos = r.Next(0, 4);
                if (check_ship_exists(Xpos, Ypos) != true) //Calls check_ship_exists if a cordinate is empty
                {
                    GameMap[Xpos, Ypos] = 1; //set ship as living
                }

            }


            /* SPELET BÖRJAR
            * 
            *  ALEKSEIS KOD
            */

            int current_amount_of_bs = random_amount_of_bs;
            int shots_fired = 0;

            for (int i = 0; i < current_amount_of_bs; i = i)
            {
                while (no_valid_input)
                {
                    Console.WriteLine("Skepapr kvar: " + current_amount_of_bs);
                    Console.WriteLine("Mata in X koordinat för kanoner att skjuta: ");
                    inx = control_input(Console.ReadLine(), 7);
                    Console.WriteLine("Mata in Y koordinat för kanoner att skjuta: ");
                    iny = control_input(Console.ReadLine(), 5);
                    if (inx != -1 && iny != -1)
                    {
                        inx--; iny--;
                        no_valid_input = false; //input is valid, exit loop
                    }
                    else
                    {
                        Console.WriteLine("***MATA IN ORDENTLIGA KOORDINATER!***");
                        Console.Beep(500, 500);
                        Console.Beep(500, 250);
                    }
                }

                if (check_ship_exists(inx, iny))
                {
                    GameMap[inx, iny] = 2; //sunken ship
                    Console.Beep(2000, 150);
                    Console.WriteLine("Du träffade!");
                    current_amount_of_bs--;
                    Draw_game_map(inx, iny, true);
                }
                else
                {
                    GameMap[inx, iny] = -1; //missmark
                    Console.WriteLine("Du missade!");
                    Draw_game_map(inx, iny, false);
                }
                shots_fired++;
                Console.WriteLine("Skott avfyrade: " + shots_fired);

                no_valid_input = true; //loop for loop again


            }
            Console.WriteLine("Du vann! Tryck på en knapp för att avsluta programmet.");
            Console.ReadLine();


        }

        //Början på Alekseis metoder
        static bool check_ship_exists(int x, int y) //
        {
            if (GameMap[x, y] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        //converts first symbol of string to char and controls if it's in range of
        //1 to 9 (all inclusive) by comparing it to ASCII table
        //also checks if input range is correct
        //returns -1 if input was incorrect in any way
        static int control_input(string input, int limit)
        {
            int output = -1;

            if (input != string.Empty)
            {
                int number = int.Parse(input);
                if (number > 0 && number < limit)
                {
                    output = number;
                }
            }
            return output;
        }


        //Slut på Alekseis kod

        //Mer kod av daniel
        static void Draw_game_map(int Xpos, int Ypos, bool hit) //dra
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == Xpos && i == Ypos && hit)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
