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


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck[i, j] = 0; //0 means not drawn. 1 means drawn one time.  2 means drawn two times and will not be drwan again.
                }
            }
            while (Game_is_running)
            {
                if (Score < 21)
                {
                    Console.WriteLine("Dra ett kort? (J/N)");
                    string awnser = Console.ReadLine();

                    if (awnser == "j" && 0 < number_of_cards_in_deck)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            type_of_card = r.Next(0, 4);
                            number_of_card = r.Next(0, 13);
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
                                            if (Score + 11 == 21 || Score + 11 < 15) //if 1 can be either 1 or 11 points the program will calculate if good. either by the score becomeing 21 or less than 15.
                                            {
                                                Console.WriteLine("du fick ett ess! Programet valde att du fick 11 poäng.");
                                                Score = Score + 11;
                                            }
                                            else
                                            {
                                                Console.WriteLine("du fick ett ess! Programet valde att du fick 1 poäng.");
                                                Score = Score + 1;
                                            }
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
                                            Score = Score + 10;
                                            break;
                                        }
                                    case 11:
                                        {
                                            number = "droting";
                                            Score = Score + 10;
                                            break;
                                        }
                                    case 12:
                                        {
                                            number = "kung";
                                            Score = Score + 10;
                                            break;
                                        }
                                }
                               

                                Console.WriteLine("Du drog: " + type + " " + number);
                                Console.WriteLine("Ditt poäng är: " + Score + " och du ska försöka få 21");
                                number_of_cards_in_deck--;
                            }
                            else
                            {
                                i--;
                            }
                        }
                    }
                    else
                    {
                        if (number_of_cards_in_deck == 0)
                        {
                            Console.WriteLine("Du fick slut på kort");
                            Console.ReadLine();
                            Game_is_running = false;
                        }
                        else
                        {
                            Console.WriteLine("Vill du slpela igen? (J/N)");
                            Play_again = Console.ReadLine();
                            if (Play_again == "j")
                            {
                                Score = 0;
                            }
                            else
                            {
                                Game_is_running = false;
                            }
                        }
                    }
                }

                else if (Score == 21)
                {
                    Console.WriteLine("Du vann!");
                    Console.WriteLine("Vill du slpela igen? (J/N)");
                    Play_again = Console.ReadLine();
                    if (Play_again == "j")
                    {
                        Score = 0;
                    }
                    else
                    {
                        Game_is_running = false;
                    }
                }
                else
                {
                    Console.WriteLine("Ditt poäng gick över 21");
                    Console.WriteLine("Du du sprack");
                    Console.WriteLine("Vill du slpela igen? (J/N)");
                    Play_again = Console.ReadLine();
                    if (Play_again == "j")
                    {
                        Score = 0;
                    }
                    else
                    {
                        Game_is_running = false;
                    }
                }
            }
        }
    }
}
