
using System;

namespace PigLatin
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("Enter your word");
            string answer = Console.ReadLine().ToLower();
            string firstLetter = answer.Substring(0, 1);
            string lastLetter = answer.Substring(answer.Length - 1, 1);
            int index = answer.IndexOfAny(vowels);
            string findFirstVowel = answer.Substring(0, index);
            string newWord = answer.Substring(index) + findFirstVowel;
            if (answer.IndexOfAny(vowels) == -1)
            {
                Console.WriteLine(newWord + "ay");
            }
            else if (firstLetter.IndexOfAny(vowels) == 0){
                if (lastLetter.IndexOfAny(vowels) == 0)
                {
                    Console.WriteLine(answer + "yay");
                } else
                {
                    Console.WriteLine(answer + "ay");
                }
            }
            else
            {
                Console.WriteLine(newWord + "ay");
            }
            Console.ReadKey();
        }
    }
   
}
