using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int computerHand = random.Next(1, 3);

            Console.WriteLine("Enter (1) rock, (2) paper, (3) scissors");
            string userHand = Console.ReadLine().ToLower();
            CompareHands(computerHand, userHand);
            Console.ReadLine();
        }
        static void CompareHands(int computerHand, string userHand)
        {
            string loss = "LOSER!";
            string dub = "WINNER WINNER CHICKEN DINNER";
            string draw = "DRAW";

            int userInput = 0;
            switch (userHand)
            {
                case "rock":
                    userInput = 1;
                    break;
                case "paper":
                    userInput = 2;
                    break;
                case "scissors":
                    userInput = 3;
                    break;
            }
            if (computerHand == userInput)
            {
                Console.WriteLine("The computer chose " + "" + computerHand);
                Console.WriteLine(string.Format(draw));
            } 
            else if (computerHand == 1 && userInput == 2)
            {
                Console.WriteLine("The computer chose " + "" + computerHand);
                Console.WriteLine(string.Format(dub));
            }
            else if (computerHand == 1 && userInput == 3)
            {
                Console.WriteLine("The computer chose " + "" + computerHand);
                Console.WriteLine(string.Format(loss));
            }
            else if (computerHand == 2 && userInput == 1)
            {
                Console.WriteLine("The computer chose " + "" + computerHand);
                Console.WriteLine(string.Format(loss));
            }
            else if (computerHand == 2 && userInput == 3)
            {
                Console.WriteLine("The Computer chose " + "" + computerHand);
                Console.WriteLine(string.Format(dub));
            }
            else if (computerHand == 3 && userInput == 1)
            {
                Console.WriteLine("The Computer chose " + "" + computerHand);
                Console.WriteLine(string.Format(dub));
            }
            else if (computerHand == 3 && userInput == 2)
            {
                Console.WriteLine("The computer chose " + "" + computerHand);
                Console.WriteLine(string.Format(loss));
            }
            Console.WriteLine();

        }
    }
}
