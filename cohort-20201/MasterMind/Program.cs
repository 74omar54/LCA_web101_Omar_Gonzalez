using System;

namespace MasterMind
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] colors = new string[] { "red", "yellow", "blue" };
            System.Collections.Generic.List<string> computerColors = new System.Collections.Generic.List<string>();
            System.Collections.Generic.List<string> userColors = new System.Collections.Generic.List<string>();
            Random random = new Random();
            computerColors.Add(colors[random.Next(1, 3)]);
            computerColors.Add(colors[random.Next(1, 3)]);
            bool isPlaying = true;
            while (isPlaying)
            {
                Console.Clear();
                userColors.Clear();

                Console.WriteLine("Welcome to MASTERMIND!");
                Console.WriteLine("Guess two colors in the correct position. choices are Red, Yellow, and Blue. Enter 'exit' to stop playing.");
                Console.WriteLine("Enter your first color.");
                userColors.Add(Console.ReadLine().ToLower().Trim());

                Console.WriteLine("Enter your second color");
                userColors.Add(Console.ReadLine().ToLower().Trim());

                if (userColors.Contains("exit"))
                {
                    break;
                }
                if(userColors[0].Equals(computerColors[0]) && userColors[1].Equals(computerColors[1]))
                {
                    Console.WriteLine("Correct! good Job");
                    break;
                }
                else if (userColors[0].Equals(computerColors[0]) || userColors[1].Equals(computerColors[1]))
                {
                    Console.WriteLine("\n0-1. You guessed one of the colors in the correct position");
                    Console.WriteLine();
                }
                else if(userColors.Contains(computerColors[0]) || userColors.Contains(computerColors[1]))
                {
                    if (userColors[0].Equals(computerColors[1]) && userColors[1].Equals(computerColors[0]))
                    {
                        Console.WriteLine("\n2-0. You guessed both of the colors but in the wrong positions.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("\n1-0. You guessed one of the colors correctly but not in the correct position.");
                        Console.WriteLine();
                    }

                    
                }
                else
                {
                    Console.WriteLine("\n0-0. You did not guess either color.");

                }
                Console.WriteLine("\nWould you like to play again? Y/N");
                isPlaying = Console.ReadLine().ToLower().Contains("y") ? true : false;
            }
            Console.WriteLine("\nGOOBYE!");
            Console.ReadKey();
        }
    }
}
