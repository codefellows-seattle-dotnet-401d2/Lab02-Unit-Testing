using System;

namespace CodeCracker
{
    public class RosettaStone
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Encrypting the following message: Hello World");
            Console.WriteLine(Encrypt("Hello World"));
            Console.WriteLine("Decrypting the following message: e>@!\"&j");
            Console.WriteLine(Decrypt("e>@!\"&j"));
            Console.ReadLine();
        }

        /// <summary>
        /// Given a string of characters, encode into a secret message using a built in key.
        /// </summary>
        /// <param name="plainText">a string that needs to be encoded</param>
        /// <returns>encoded version of plainText string</returns>
        public static string Encrypt(string plainText)
        {
            string encryptedMsg = "";
            // hard coded keys, index of alphabet relates to same index in decoder
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] decoder = { '!', ')', '"', '(', '£', '*', '%', '&', '>', '<', '@', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o' };
            // for every character in plainText, it will append to a new string with the encoded version of that character
            foreach (char c in plainText.ToLower())
            {
                int index = Array.IndexOf(alphabet, c);
                if (index != -1) encryptedMsg += decoder[index];
                else encryptedMsg += " ";
            }
            return encryptedMsg;
        }

        /// <summary>
        /// Given a string of characters, decode secret message into plain text using built in key.
        /// </summary>
        /// <param name="encryptedMsg">a string that needs to be decoded</param>
        /// <returns>decoded version of encryptedMsg string</returns>
        public static string Decrypt(string encryptedMsg)
        {
            string plainText = "";
            // hard coded keys, index of alphabet relates to same index in decoder
            char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            char[] decoder = {'!',')','"','(','£','*','%','&','>','<','@','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o'};
            // for every character in encryptedMsg, it will append to a new string with the decoded version of that character
            foreach (char c in encryptedMsg.ToLower())
            {
                int index = Array.IndexOf(decoder, c);
                if (index != -1) plainText += alphabet[index];
                else plainText += " ";
            }
            return plainText;
        }
    }
}
