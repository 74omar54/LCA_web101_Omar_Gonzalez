using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int comuterHand = random.Next(1, 3);

            Console.WriteLine("Enter rock, paper, scissors");
            string answer = Console.ReadLine().ToLower();
        }
        static void CompareHands(int computerHand, string userHand)
        {

        }
    }
}
