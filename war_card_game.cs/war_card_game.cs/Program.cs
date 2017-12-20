using System;

class War
{
    static int[] deck = new int[52]; //using logic that 1-52 is all cards, with Ace of clubs, diamonds, hearts, and spades as 
    static string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
    static string[] suits = { "hearts", "diamonds", "clubs", "spades" };
    static Random rand = new Random();

    static void Main()
    {
        int totalPlayer1 = 0;
        int totalPlayer2 = 0;

        for (int i = 0; i < 26; i++)
        {

        }
    }

    static void FillDeck()
    {
        for (int i = 0; i < 52; i++)
        {
            while (true)
            {
                int num = rand.Next(1, 53);
                if (Array.IndexOf(deck, num) == -1)
                {
                    deck[i] = num;
                    break;
                }
            }
        }
    }
}


