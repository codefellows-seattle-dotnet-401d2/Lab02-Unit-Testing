using System;

namespace CodeCracker
{
    public class HackerTime
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Decrypt("hello"));
            Console.ReadLine();
        }

        public static string Encrypt()
        {
            return "testing";
        }

        public static string Decrypt(string encodedMessage)
        {
            string decodedMessage = "";
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] decoder = { '!', ')', '"', '(', '£', '*', '%', '&', '>', '<', '@', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o' };
            foreach (char i in encodedMessage)
            {
                int index = Array.IndexOf(decoder, i);
                Console.WriteLine("" + index);
                decodedMessage += alphabet[index];
            }
            return decodedMessage;
        }
    }
}