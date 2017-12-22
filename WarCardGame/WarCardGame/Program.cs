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

        /// <summary>
        /// This would normally instantiate the deck and players hands and control the main loop of the game until someone wins.
        /// </summary>
        private static void StartGame()
        {
            /* This is not being implemented, but below is how the internal representation
             * of the cards would be to make comparing two cards easier.
             * 2-10: self explanitory
             * 11: Jack, 12: Queen, 13: King, 14: Ace
             * .1: Spades, .2: Clubs, .3: Diamonds, .4: Hearts
            */
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
            // A bit redundant since I have Xunit tests, but I wanted some output when running the actual program.
            IsCardOneHigher(11.3, 4.2);
            IsCardOneHigher(11.3, 12.2);
            IsCardOneHigher(6.3, 6.2);
            IsCardOneHigher(6.1, 6.4);
            Console.ReadLine();
        }

        /// <summary>
        /// This is used to get a string description of the value and suit of a card based on the internal number representation.
        /// </summary>
        /// <param name="card">A double from the pool in deckOfCards array, passed in as the current card being played</param>
        /// <returns>A string of what the cards suit and value are</returns>
        public static string ConvertToCardName(double card)
        {
            // type casting to remove the decimal
            int value = (int)card;
            // turning the decimal into its own whole number. this was the only way I found avoid math rounding errors
            double suit = (card * 10) - (Math.Floor(card) * 10);
            string cardName = "";

            // the card's value being appended to the returning string
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
            // the card's suit being appended to the returning string
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

        /// <summary>
        /// Determines if card 1 is higher than card 2 and informs the players.
        /// </summary>
        /// <param name="card1">double type. player 1's current card played.</param>
        /// <param name="card2">double type. player 2's current card played.</param>
        /// <returns>boolean if card 1 wins or not by being a higher value</returns>
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
