using System;

namespace WarCardGame
{
    public class Game
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to WAR (card game)!");
            StartGame();
        }

        private static void StartGame()
        {
            //11:Jack, 12:Queen, 13:King, 14:Ace
            //.1:spades, .2:clubs, .3:diamonds, .4:hearts
            double[] deckOfCards =
            {
                2.1, 2.2, 2.3, 2.4,
                3.1, 3.2, 3.3, 3.4,
                4.1, 4.2, 4.3, 4.4,
                5.1, 5.2, 5.3, 5.4,
                6.1, 6.2, 6.3, 6.4,
                7.1, 7.2, 7.3, 7.4,
                8.1, 8.2, 8.3, 8.4,
                9.1, 9.2, 9.3, 9.4,
                10.1,10.2,10.3,10.4,
                11.1,11.2,11.3,11.4,
                12.1,12.2,12.3,12.4,
                13.1,13.2,13.3,13.4,
                14.1,14.2,14.3,14.4,
            };
            IsCardOneHigher(11.3, 4.2);
            IsCardOneHigher(11.3, 12.2);
            IsCardOneHigher(6.3, 6.2);
            IsCardOneHigher(6.1, 6.4);
            Console.ReadLine();
        }

        public static string ConvertToCardName(double card)
        {
            int value = (int)card;
            double suit = (card * 10) - (Math.Floor(card) * 10);
            string cardName = "";
            Console.WriteLine(value + " " + suit);

            switch (value)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    cardName += value + " of ";
                    break;
                case 11:
                    cardName += "Jack of ";
                    break;
                case 12:
                    cardName += "Queen of ";
                    break;
                case 13:
                    cardName += "King of ";
                    break;
                case 14:
                    cardName += "Ace of ";
                    break;
                default:
                    cardName += "Value of ";
                    break;
            }
            switch (suit)
            {
                case 1:
                    cardName += "Spades";
                    break;
                case 2:
                    cardName += "Clubs";
                    break;
                case 3:
                    cardName += "Diamonds";
                    break;
                case 4:
                    cardName += "Hearts";
                    break;
                default:
                    cardName += "Suit";
                    break;
            }

            return cardName;
        }

        public static bool IsCardOneHigher(double card1, double card2)
        {
            Console.WriteLine("\nPlaying Turn");
            if (card1 > card2)
            {
                Console.WriteLine(@"{0} beats {1}", ConvertToCardName(card1), ConvertToCardName(card2));
                return true;
            }
            else
            {
                Console.WriteLine(format: @"{0} loses to {1}", arg0: ConvertToCardName(card1), arg1: ConvertToCardName(card2));
                return false;
            }
        }
    }
}
