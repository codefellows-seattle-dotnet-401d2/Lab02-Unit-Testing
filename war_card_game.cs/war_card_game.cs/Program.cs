using System;


namespace WarCardGame
{
    public class Game
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to War Card Game!");
            StartGame();
        }

        /// <summary>
        /// This would normally instantiate the deck and players hands and control the main loop of the game until someone wins.
        /// </summary>
        private static void StartGame()
        {
            /* 2-10: number crads
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
            
        }

        /// <summary>
        /// Converting a number value for suit and card value into English string values
        /// </summary>
        
        public static string ConvertToCardName(double card)
        {
            // converting to integer
            int value = (int)card;

            // rounding
            double suit = (card * 10) - (Math.Floor(card) * 10);
            string cardName = "";

          
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
        /// Determines if card 1 is higher than card 2 and displays result onscreen
        /// </summary>
       
        public static bool IsCardOneHigher(double card1, double card2)
        {
            Console.WriteLine("\nPlaying Turn");
            if (card1 > card2)
            {
                Console.WriteLine(@"{0} is higher than {1}", ConvertToCardName(card1), ConvertToCardName(card2));
                return true;
            }

            else
            {
                Console.WriteLine(format: @"{0} is lower than {1}", arg0: ConvertToCardName(card1), arg1: ConvertToCardName(card2));
                return false;
            }
        }
    }
}
/*
class War
{
    static int[] deck = new int[52]; //using logic that 1-52 is all cards, with 2 of clubs, diamonds, hearts, and spades as 1-4
    static int lastCardIndex = 0;
    static string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
    static string[] suits = { "hearts", "diamonds", "clubs", "spades" };
    static Random random = new Random();

    static void Main()
    {
        int totalPlayer1 = 0;
        int totalPlayer2 = 0;

        for (int i = 0; i < 26; i++)
        {
            string player1Suit;
            int player1 = SelectCard(out player1Suit) - 1;
            string player2Suit;
            int player = SelectCard(out player2Suit) - 1;
        }
    }

    static void RefillDeck()
    {
        for (int i = 0; i < 52; i++)
        {
            while (true)
            {
                int number = random.Next(1, 53);
                if (Array.IndexOf(deck, number) == -1)
                {
                    deck[i] = number;
                    break;
                }
            }
        }
    }

    static int SelectCard(out string suit)
    {
        int num = deck[lastCardIndex];
        lastCardIndex++;
    }
}
/*

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Realized we didn't need to do this much for project, actual attempt above*//


