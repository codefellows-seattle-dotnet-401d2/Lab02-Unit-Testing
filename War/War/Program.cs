using System;

namespace War
{
    public class WarGame
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to War");
            WinLoss();
            Console.ReadLine();
        }

        /// <summary>
        /// randomizes the card returned
        /// </summary>
        /// <returns>int of card</returns>
        public static int Rando()
        {
            Random random = new Random();
            int computer = random.Next(2, 13);
            return computer;
        }

        /// <summary>
        /// compare the random numbers and return results
        /// </summary>
        public static void WinLoss()
        {
            int computer = Rando();
            int player = Rando();

            if (player > computer)
            {
                Console.WriteLine("Result: You win!");
            }
            else if (player == computer)
            {
                Console.WriteLine("Result: War!");
            }
            else
            {
                Console.WriteLine("Result: You Lose!");
            }
            Console.WriteLine($"Computer: {computer}");
            Console.WriteLine($"Player: {player}");
        }
    }
}
