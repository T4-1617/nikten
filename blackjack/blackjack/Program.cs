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

        static int Compute_Score = 0;
        static int Player_Score = 0;
        static int Computer_total_score = 0;
        static int Player_total_score = 0;
        static string awnser = string.Empty;
        static Boolean Game_is_running = true;


        static void Main(string[] args)
        {
            int number_of_cards_in_deck = 52 * 4;
            int type_of_card = 0;
            int number_of_card = 0;
            Random r = new Random();

            string type = string.Empty;
            string number = string.Empty;
            string Play_again = string.Empty;



            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck[i, j] = 0; //0 means not drawn. 1 means drawn one time.  2 means drawn two times e.c.t. When a card is drawn 4 times it will not be drawn again.
                }
            }
            while (Game_is_running)
            {
                if (Player_Score < 21 && Compute_Score < 21)
                {
                    if (awnser == "n")
                    {
                        Computer_turn();
                    }
                    else
                    {
                        Console.WriteLine("Dra ett kort? (J/N)");
                        awnser = Console.ReadLine();

                        if (awnser == "j" && 0 < number_of_cards_in_deck)
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                type_of_card = r.Next(0, 4);
                                number_of_card = r.Next(0, 13);
                                if (deck[type_of_card, number_of_card] == 0 || deck[type_of_card, number_of_card] == 1 ||
                                    deck[type_of_card, number_of_card] == 2 || deck[type_of_card, number_of_card] == 3)
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
                                                if (Player_Score + 11 == 21 || Player_Score + 11 < 15) //if 1 can be either 1 or 11 points the program will calculate if good. either by the score becomeing 21 or less than 15.
                                                {
                                                    Console.WriteLine("du fick ett ess! Programet valde att du fick 11 poäng.");
                                                    Player_Score = Player_Score + 11;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("du fick ett ess! Programet valde att du fick 1 poäng.");
                                                    Player_Score = Player_Score + 1;
                                                }
                                                break;
                                            }
                                        case 1:
                                            {
                                                number = "2";
                                                Player_Score = Player_Score + 2;
                                                break;
                                            }
                                        case 2:
                                            {
                                                number = "3";
                                                Player_Score = Player_Score + 3;
                                                break;
                                            }
                                        case 3:
                                            {
                                                number = "4";
                                                Player_Score = Player_Score + 4;
                                                break;
                                            }
                                        case 4:
                                            {
                                                number = "5";
                                                Player_Score = Player_Score + 5;
                                                break;
                                            }
                                        case 5:
                                            {
                                                number = "6";
                                                Player_Score = Player_Score + 6;
                                                break;
                                            }
                                        case 6:
                                            {
                                                number = "7";
                                                Player_Score = Player_Score + 7;
                                                break;
                                            }
                                        case 7:
                                            {
                                                number = "8";
                                                Player_Score = Player_Score + 8;
                                                break;
                                            }
                                        case 8:
                                            {
                                                number = "9";
                                                Player_Score = Player_Score + 9;
                                                break;
                                            }
                                        case 9:
                                            {
                                                number = "10";
                                                Player_Score = Player_Score + 10;
                                                break;
                                            }
                                        case 10:
                                            {
                                                number = "knäckt";
                                                Player_Score = Player_Score + 10;
                                                break;
                                            }
                                        case 11:
                                            {
                                                number = "droting";
                                                Player_Score = Player_Score + 10;
                                                break;
                                            }
                                        case 12:
                                            {
                                                number = "kung";
                                                Player_Score = Player_Score + 10;
                                                break;
                                            }
                                    }

                                    Console.WriteLine("--------------------");
                                    Console.WriteLine("Du drog: " + type + " " + number);
                                    Console.WriteLine("Ditt poäng är: " + Player_Score + " och du ska försöka få 21");
                                    Console.WriteLine("--------------------");
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
                            if (Compute_Score < Player_Score)
                            {

                            }
                            else
                            {
                                if (number_of_cards_in_deck < 15)
                                {
                                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
                                    Console.WriteLine("Det är snart slut på kort. vi blandar om nu");
                                    Console.WriteLine("Tryck på enter för att återgå till spelet");
                                    for (int i = 0; i < 4; i++)
                                    {
                                        for (int j = 0; j < 13; j++)
                                        {
                                            deck[i, j] = 0;
                                        }
                                    }
                                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Vill du slpela igen? (J/N)");
                                    Play_again = Console.ReadLine();
                                    if (Play_again == "j")
                                    {
                                        awnser = string.Empty;
                                        Compute_Score = 0;
                                        Player_Score = 0;
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

                else if (Player_Score == 21)
                {
                    Console.WriteLine("Du vann!");
                    Console.WriteLine("Vill du slpela igen? (J/N)");
                    Play_again = Console.ReadLine();
                    if (Play_again == "j")
                    {
                        awnser = string.Empty;
                        Compute_Score = 0;
                        Player_Score = 0;
                    }
                    else
                    {
                        Game_is_running = false;
                    }
                }
                else if (Compute_Score == 21)
                {
                    Console.WriteLine("Datorn Vann!");
                    Console.WriteLine("Vill du slpela igen? (J/N)");
                    Play_again = Console.ReadLine();
                    if (Play_again == "j")
                    {
                        awnser = string.Empty;
                        Compute_Score = 0;
                        Player_Score = 0;
                    }
                    else
                    {
                        Game_is_running = false;
                    }
                }
                else
                {
                    if (Player_Score > 21)
                    {
                        Console.WriteLine("Ditt poäng gick över 21");
                        Console.WriteLine("Du du sprack");
                        Console.WriteLine("Vill du slpela igen? (J/N)");
                        Play_again = Console.ReadLine();
                        if (Play_again == "j")
                        {
                            awnser = string.Empty;
                            Compute_Score = 0;
                            Player_Score = 0;
                        }
                        else
                        {
                            Game_is_running = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Datorns poäng gick över 21");
                        Console.WriteLine("Vill du slpela igen? (J/N)");
                        Play_again = Console.ReadLine();
                        if (Play_again == "j")
                        {
                            awnser = string.Empty;
                            Compute_Score = 0;
                            Player_Score = 0;
                        }
                        else
                        {
                            Game_is_running = false;
                        }
                    }
                }
            }
        }

        static void Computer_turn()
        {
            int number_of_cards_in_deck = 52 * 4;
            int type_of_card = 0;
            int number_of_card = 0;
            Random r = new Random();

            string type = string.Empty;
            string number = string.Empty;


            if (0 < number_of_cards_in_deck && Player_Score < 21)
            {
                if (Compute_Score <= Player_Score)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        type_of_card = r.Next(0, 4);
                        number_of_card = r.Next(0, 13);
                        if (deck[type_of_card, number_of_card] == 0 || deck[type_of_card, number_of_card] == 1 ||
                            deck[type_of_card, number_of_card] == 2 || deck[type_of_card, number_of_card] == 3)
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
                                        if (Compute_Score + 11 == 21 || Compute_Score + 11 < 15) //if 1 can be either 1 or 11 points the program will calculate if good. either by the score becomeing 21 or less than 15.
                                        {
                                            Compute_Score = Compute_Score + 11;
                                        }
                                        else
                                        {
                                            Compute_Score = Compute_Score + 1;
                                        }
                                        break;
                                    }
                                case 1:
                                    {
                                        number = "2";
                                        Compute_Score = Compute_Score + 2;
                                        break;
                                    }
                                case 2:
                                    {
                                        number = "3";
                                        Compute_Score = Compute_Score + 3;
                                        break;
                                    }
                                case 3:
                                    {
                                        number = "4";
                                        Compute_Score = Compute_Score + 4;
                                        break;
                                    }
                                case 4:
                                    {
                                        number = "5";
                                        Compute_Score = Compute_Score + 5;
                                        break;
                                    }
                                case 5:
                                    {
                                        number = "6";
                                        Compute_Score = Compute_Score + 6;
                                        break;
                                    }
                                case 6:
                                    {
                                        number = "7";
                                        Compute_Score = Compute_Score + 7;
                                        break;
                                    }
                                case 7:
                                    {
                                        number = "8";
                                        Compute_Score = Compute_Score + 8;
                                        break;
                                    }
                                case 8:
                                    {
                                        number = "9";
                                        Compute_Score = Compute_Score + 9;
                                        break;
                                    }
                                case 9:
                                    {
                                        number = "10";
                                        Compute_Score = Compute_Score + 10;
                                        break;
                                    }
                                case 10:
                                    {
                                        number = "knäckt";
                                        Compute_Score = Compute_Score + 10;
                                        break;
                                    }
                                case 11:
                                    {
                                        number = "droting";
                                        Compute_Score = Compute_Score + 10;
                                        break;
                                    }
                                case 12:
                                    {
                                        number = "kung";
                                        Compute_Score = Compute_Score + 10;
                                        break;
                                    }
                            }

                            Console.WriteLine("********************");
                            Console.WriteLine("Datorn drog: " + type + " " + number);
                            Console.WriteLine("Datorns poäng är: " + Compute_Score);
                            Console.WriteLine("********************");
                            number_of_cards_in_deck--;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Datorn Vann!");
                    Console.WriteLine("Vill du slpela igen? (J/N)");
                    string Play_again = Console.ReadLine();
                    if (Play_again == "j")
                    {
                        awnser = string.Empty;
                        Compute_Score = 0;
                        Player_Score = 0;
                    }
                    else
                    {
                        Game_is_running = false;
                    }
                }
            }
            else
            {
                return;
            }
        }
    }
}
