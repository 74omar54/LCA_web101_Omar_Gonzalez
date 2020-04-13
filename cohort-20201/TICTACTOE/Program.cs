using System;

namespace TICTACTOE 
{
    class MainClass
    {
        public static string[,] Board;
        public static void Main(string[] args)
        {
            initializeBoard();
            bool isPlaying = true;
            string playerLetter = "x";

            while (isPlaying)
            {
                printBoard();
                Console.WriteLine(string.Format(playerLetter) + "Enter the number of the square.");
                string answer = Console.ReadLine();
                if (!int.TryParse(answer, out int number))
                {
                    Console.WriteLine("you did not enter a valid square. Press any key to try again");
                    Console.ReadKey();
                    continue;
                }
                else
                {
                    if (placeMark(answer, playerLetter))
                    {
                        printBoard();
                        if (hasWon(playerLetter))
                        {
                            Console.WriteLine("player" + string.Format(playerLetter) + "wins!");
                            if (playAgain())
                            {
                                continue;
                            }
                            else break;
                        }
                        else if (isTie())
						{
                            Console.WriteLine("No winner");
                            if (playAgain())
                            {
                                continue;
                            }
                            else break;
						}
                        else
						{
                            playerLetter = (playerLetter == "x") ? "o" : "x";
						}
                   }
                }
            }

        }
        private static bool playAgain()
        {
            Console.WriteLine("\nWould you like to play again? Y/N");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain.Contains("y"))
			{
                initializeBoard();
                return true;
			}
			else
			{
                return false;
			}

        }
        private static bool isTie()
        {
           for (int i = 0; i < 3; i++)
			{
                for (int j = 0; j < 3; j++)
				{
                    if (!Board[i,j].Equals("x") && !Board[i, j].Equals("o"))
					{
                        return false;
					}
				}
			}
            return true;
        }
        private static bool hasWon(string playerLetter)
        {
            if (isHorizontalWin(playerLetter) || isVerticalWin(playerLetter) || isDiagonalWin(playerLetter))
			{
                return true;
			}
            return false;
        }                            
        private static bool isDiagonalWin(string playerLetter)
        {
            if (Board[0, 0].Equals(playerLetter) && Board[1, 1].Equals(playerLetter) && Board[2, 2].Equals(playerLetter) ||
                Board[2, 0].Equals(playerLetter) && Board[1, 1].Equals(playerLetter) && Board[0, 2].Equals(playerLetter))
			{
                return true;
			}
            return false;
        }
        private static bool isVerticalWin(string playerLetter)
        {
            for (int i = 0; i < 3; i++)
			{
                if (Board[0, i].Contains(playerLetter) &&
                    Board[0, i].Equals(Board[1, i]) &&
                    Board[1, i].Equals(Board[2, i]))
				{
                    return true;
				}                      
			}
            return false;

        }
        private static bool isHorizontalWin(string playerLetter)
        {
            for (int i = 0; i < 3; i++)
			{
                if (Board[i, 0].Contains(playerLetter) &&
                    Board[i, 0].Equals(Board[i, 1]) &&
                    Board[i, 1].Equals(Board[i, 2]))
				{
                    return true;
				}
                
			}
            return false;
        }
        static bool placeMark(string square, string player)
        {
            string otherPlayer = player == "x" ? "o" : "x";
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (Board[i, j].Equals(square) &&
                            (!Board[i, j].Equals(otherPlayer) || !Board[i, j].Equals(player)))
					{
                        Board[i, j] = player;
                        return true;

                    }  
               }
            }
            return false;
        }
        static void printBoard()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\t" + Board[i, 0] + " | " + Board[i, 1] + " | " + Board[i, 2]);
                if (i < 2)
                {
                    Console.WriteLine("\t----------");
                }
            }
            
        }
        static void initializeBoard()
        {
            Board = new string[3, 3]
            {
                    { "1", "2", "3" },
                    { "4", "5", "6" },
                    { "7", "8", "9" },
            };
        }
    }

}   