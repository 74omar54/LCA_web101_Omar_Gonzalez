
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
            if (answer.IndexOfAny(vowels) == -1)
            {
                Console.WriteLine(answer + "ay");
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
                int vowelIndex = answer.IndexOfAny(vowels);
                string gettingConsonants = answer.Substring(0, vowelIndex);
                string newWord = answer.Substring(vowelIndex) + gettingConsonants + "ay";
                Console.WriteLine(newWord);
            }
            Console.ReadKey();
            
        }
    }
   
}
