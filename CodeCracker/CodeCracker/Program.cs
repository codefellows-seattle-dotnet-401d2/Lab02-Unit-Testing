using System;

namespace CodeCracker
{
    public class RosettaStone
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Decrypt("mno"));
            Console.ReadLine();
        }

        public static string Encrypt()
        {
            return "test string";
        }

        public static string Decrypt(string encodedMsg)
        {
            string decodedMsg = "";
            char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            char[] decoder = {'!',')','"','(','£','*','%','&','>','<','@','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o'};
            foreach(char c in encodedMsg)
            {
                int index = Array.IndexOf(decoder, c);
                Console.WriteLine(""+index);
                decodedMsg += alphabet[index];
            }
            return decodedMsg;
        }
    }
}
