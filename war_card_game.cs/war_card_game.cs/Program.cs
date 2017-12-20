using System;
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
//Realized we didn't need to do this much for project, actual attempt below*//


