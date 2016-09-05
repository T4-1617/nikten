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


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                   card[i, j] = 0; //0 means not drawn. 1 means drawn.
                }
            }

            Console.WriteLine("Tryck enter för att dra ett kort");
            Console.ReadLine();
            Random r = new Random();
            int type_of_card; // deterimin what card type.
            int number_of_card; // determind the card number. Ace is one.

            for (int i = 0; i < Cards_in_deck; i++)
            {
                type_of_card = r.Next(0, 3) + 1; //Add one so it will start at one and go up to 4.
                number_of_card = r.Next(0, 12) + 1; //Add one so it will start at one and go up to 4.
                if (card[type_of_card, number_of_card] == 0)
                {
                    Console.WriteLine("Tryck enter för ett nyt kort");
                    Console.ReadLine();
                    switch (type_of_card)
                    {
                        case 1:
                            {
                                type = "hjärter";
                                break;
                            }
                        case 2:
                            {
                                type = "ruter";
                                break;
                            }
                        case 3:
                            {
                                type = "spader";
                                break;
                            }
                        case 4:
                            {
                                type = "klöver";
                                break;
                            }
                    }
                    switch (number_of_card)
                    {
                        case 1:
                            {
                                number = "ess";
                                break;
                            }
                        case 2:
                            {
                                number = "2";
                                break;
                            }
                        case 3:
                            {
                                number = "3";
                                break;
                            }
                        case 4:
                            {
                                number = "4";
                                break;
                            }
                        case 5:
                            {
                                number = "5";
                                break;
                            }
                        case 6:
                            {
                                number = "6";
                                break;
                            }
                        case 7:
                            {
                                number = "7";
                                break;
                            }
                        case 8:
                            {
                                number = "8";
                                break;
                            }
                        case 9:
                            {
                                number = "9";
                                break;
                            }
                        case 10:
                            {
                                number = "10";
                                break;
                            }
                        case 11:
                            {
                                number = "knäckt";
                                break;
                            }
                        case 12:
                            {
                                number = "droting";
                                break;
                            }
                        case 13:
                            {
                                number = "kung";
                                break;
                            }
                    }
                    Console.WriteLine(type + " " + number);
                    card[type_of_card, number_of_card] = 1;

                }
                else
                {
                    i--;
                }
            }
        }
    }
}
