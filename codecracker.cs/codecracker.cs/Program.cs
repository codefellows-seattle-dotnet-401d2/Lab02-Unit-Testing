using System;

namespace CodeCracker
{
    public class GettingCryptic
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Encrypt: Trying things");
            Console.WriteLine(Encrypt("Trying things"));

            Console.WriteLine("Decrypt: >*bbe");
            Console.WriteLine(Decrypt(">*bbe"));

            Console.ReadLine();
        }

        /// <summary>
        /// Given a string of characters, encode into a secret message using a built in key.
        /// </summary>
    
        public static string Encrypt(string words)
        {
            string encryptMessage = "";
            
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] code = { '!', ')', '"', '(', '£', '*', '%', '&', '>', '<', '@', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o' };
           

            foreach (char c in plainText.ToLower())
            {
                int index = Array.IndexOf(alphabet, c);
                if (index != -1) encryptMessage += code[index];
                else encryptMessage += " ";
            }
            return encryptMessage;
        }

        /// <summary>
        /// Given a string of characters, decode secret message into plain text using built in key.
        /// </summary>
   
        public static string Decrypt(string encryptMessage)
        {
            string words = "";

            char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            char[] code = {'!',')','"','(','£','*','%','&','>','<','@','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o'};

            foreach (char c in encryptMessage.ToLower())
            {
                int index = Array.IndexOf(code, c);
                if (index != -1) words += alphabet[index];
                else plainText += " ";
            }
            return words;
        }
    }
}