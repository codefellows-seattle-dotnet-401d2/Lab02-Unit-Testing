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

        public static string Encrypt(string plainText)
        {
            string encryptedMsg = "";
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] decoder = { '!', ')', '"', '(', '£', '*', '%', '&', '>', '<', '@', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o' };
            foreach (char c in plainText.ToLower())
            {
                int index = Array.IndexOf(alphabet, c);
                if (index != -1) encryptedMsg += decoder[index];
                else encryptedMsg += " ";
            }
            return encryptedMsg;
        }

        public static string Decrypt(string encryptedMsg)
        {
            string plainText = "";
            char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            char[] decoder = {'!',')','"','(','£','*','%','&','>','<','@','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o'};
            foreach(char c in encryptedMsg.ToLower())
            {
                int index = Array.IndexOf(decoder, c);
                if (index != -1) plainText += alphabet[index];
                else plainText += " ";
            }
            return plainText;
        }
    }
}
