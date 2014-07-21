namespace EnglishNamesOfCards
{
    //Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
    //The cards should be printed with their English names. Use nested for loops and switch-case

    using System;

    class EnglishNamesOfCards
    {
        static void Main()
        {
            string suit = String.Empty;
            string rank = String.Empty;

            Console.SetWindowSize(110, 30);

            for (int j = 1; j <= 13; j++)
            {
                string row = String.Empty;
                
                switch (j)
                {
                    case 1:
                        rank = "Ace";
                        break;
                    case 2:
                        rank = "2";
                        break;
                    case 3:
                        rank = "3";
                        break;
                    case 4:
                        rank = "4";
                        break;
                    case 5:
                        rank = "5";
                        break;
                    case 6:
                        rank = "6";
                        break;
                    case 7:
                        rank = "7";
                        break;
                    case 8:
                        rank = "8";
                        break;
                    case 9:
                        rank = "9";
                        break;
                    case 10:
                        rank = "10";
                        break;
                    case 11:
                        rank = "Jack";
                        break;
                    case 12:
                        rank = "Queen";
                        break;
                    case 13:
                        rank = "King";
                        break;
                    default:
                        break;
                }

                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            suit = "clubs";
                            break;
                        case 1:
                            suit = "diamonds";
                            break;
                        case 2:
                            suit = "hearts";
                            break;
                        case 3:
                            suit = "spades";
                            break;
                        default:
                            break;
                    }

                    string card = rank + " of " + suit;
                    card = card.PadRight(25);
                    row += card;
                }

                Console.WriteLine(row);
            }
        }
    }
}
