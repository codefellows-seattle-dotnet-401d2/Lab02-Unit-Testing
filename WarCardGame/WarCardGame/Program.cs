using System;

namespace WarCardGame
{
    public class Game
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to WAR (card game)!");
        }

        public static bool IsCardOneHigher(int card1, int card2)
        {
            if (card1 > card2) return true;
            else return false;
        }
    }
}
