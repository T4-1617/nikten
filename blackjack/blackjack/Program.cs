using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Program
    {
        static int[,] deck = new int[4, 13];

        static void Main(string[] args)
        {
            int number_of_cards_in_deck = 52 * 2;
            int type_of_card = 0;
            int number_of_card = 0;
            Random r = new Random();

            string type = string.Empty;
            string number = string.Empty;
            string Play_again = string.Empty;
            Boolean Game_is_running = true;
            int Score = 0;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    deck[i + 1, j + 1] = 0; //0 means not drawn. 1 means drawn one time.  2 means drawn two times.
                }
            }
            Console.WriteLine("Dra ett kort? (J/N)");
            string awnser = Console.ReadLine();
            while (Game_is_running)
            {
                if (Score < 21)
                {
                    Console.WriteLine("Dra ett till kort? (J/N)");
                    awnser = Console.ReadLine();

                    if (awnser == "j")
                    {
                        type_of_card = r.Next(0, 4);
                        number_of_card = r.Next(0, 13);
                        for (int i = 0; i < 1;)
                        {
                            if (deck[type_of_card, number_of_card] == 0 || deck[type_of_card, number_of_card] == 1)
                            {
                                deck[type_of_card, number_of_card] = deck[type_of_card, number_of_card] + 1;
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
                                i++;

                                Console.WriteLine("Du drog: " + type + " " + number);
                                Console.WriteLine("Ditt poäng är:" + Score + " och du ska försöka få 21");
                            }
                        }
                    }
                    else
                    {
                    }
                }
                else if (Score == 21)
                {
                    Console.WriteLine("Du vann!");
                }
                else
                {
                    Console.WriteLine("Du förlora.");
                }
            }
        }
    }
}
