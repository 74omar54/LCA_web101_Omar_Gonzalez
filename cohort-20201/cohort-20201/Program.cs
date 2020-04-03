using System;

namespace PigLatin
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            Console.WriteLine("Enter your word");
            string answer = Console.ReadLine();

            string firstLetter = answer.Substring(0, 1);
            string lastLetter = answer.Substring(answer.Length - 1, 1);
            int index = answer.IndexOfAny(vowels);

            string newWord = answer.Substring(1);

            if (answer.IndexOfAny(vowels) >= 0)
            {
                Console.WriteLine("True");
            }



        }
    }
}
