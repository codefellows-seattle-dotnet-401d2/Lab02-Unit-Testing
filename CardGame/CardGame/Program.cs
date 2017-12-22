using System;

namespace CardGame
{
    public class Game
    {
        public static void Main(string[] args)
        {
            /*int[] deck = new int[52];            
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            string[] suits = { "hearts", "diamonds", "clubs", "spades" };
            Random random = new Random();*/

            Console.WriteLine("What is your name Soldier?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Are you ready to play WAR {userName}!");
            Console.ReadLine();
        }

        public static bool OneHigh(int card1, int card2)
        {
            if (card1 > card2) return true;
            else return false;
        }
    }
}