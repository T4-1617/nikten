using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kortlek_consloe_uppgift
{
    class Program
    {
        static int[,] card = new int[4, 13]; //create array for cards

        /*
         * first int will be type. second what card number.
         * 1 = hjärter
         * 2 = ruter 
         * 3 = spader 
         * 4 = klöver
         */


        static void Main(string[] args)
        {
            int Cards_in_deck = 52;
            string type = string.Empty;
            string number = string.Empty;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    card[i + 1, j + 1] = 0; //0 means not drawn. 1 means drawn.
                }
            }
            Random r = new Random();
            int type_of_card; // deterimin what card type.
            int number_of_card; // determind the card number. Ace is one.
            int Score = 0; // detitminds the score of the player

            for (int i = 0; i < Cards_in_deck;)
            {
                type_of_card = r.Next(0, 4); //Add one so it will start at one and go up to 4.
                number_of_card = r.Next(0, 13); //Add one so it will start at one and go up to 4.
                if (card[type_of_card, number_of_card] == 0)
                {
                    Console.WriteLine("Tryck enter för ett kort");
                    Console.ReadLine();
                    card[type_of_card, number_of_card] = 1;
                    switch (type_of_card)
                    {
                        case 0:
                            {
                                type = "hjärter";
                                break;
                            }
                        case 1:
                            {
                                type = "ruter";
                                break;
                            }
                        case 2:
                            {
                                type = "spader";
                                break;
                            }
                        case 3:
                            {
                                type = "klöver";
                                break;
                            }
                    }
                    switch (number_of_card)
                    {
                        case 0:
                            {
                                number = "ess";
                                Score = Score + 1;
                                break;
                            }
                        case 1:
                            {
                                number = "2";
                                Score = Score + 2;
                                break;
                            }
                        case 2:
                            {
                                number = "3";
                                Score = Score + 3;
                                break;
                            }
                        case 3:
                            {
                                number = "4";
                                Score = Score + 4;
                                break;
                            }
                        case 4:
                            {
                                number = "5";
                                Score = Score + 5;
                                break;
                            }
                        case 5:
                            {
                                number = "6";
                                Score = Score + 6;
                                break;
                            }
                        case 6:
                            {
                                number = "7";
                                Score = Score + 7;
                                break;
                            }
                        case 7:
                            {
                                number = "8";
                                Score = Score + 8;
                                break;
                            }
                        case 8:
                            {
                                number = "9";
                                Score = Score + 9;
                                break;
                            }
                        case 9:
                            {
                                number = "10";
                                Score = Score + 10;
                                break;
                            }
                        case 10:
                            {
                                number = "knäckt";
                                Score = Score + 11;
                                break;
                            }
                        case 11:
                            {
                                number = "droting";
                                Score = Score + 12;
                                break;
                            }
                        case 12:
                            {
                                number = "kung";
                                Score = Score + 13;
                                break;
                            }
                    }
                    Console.WriteLine("Ditt kort är: " + type + " " + number + "\n" +" Du har " + (Cards_in_deck - i - 1) + " kort kvar");
                    Console.WriteLine("Ditt poäng är: " + Score);
                    i++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Du är klar");
            Console.ReadLine();
        }
    }
}
