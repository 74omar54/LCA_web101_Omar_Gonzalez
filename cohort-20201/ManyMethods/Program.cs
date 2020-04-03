using System;

namespace ManyMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Addition();
            catDog();
            oddEvent();
            inches();
            echo();
            killGrams();
            date();
            age();
            guess();




        }
        public static void Hello()
        {
            Console.WriteLine("What is your name?");
            Console.ReadLine();
            Console.WriteLine("Bye Bob");
        }
        public static void Addition()
        {
            Console.WriteLine("Enter your first number");
            string answer = Console.ReadLine();
            Console.WriteLine("Enter your second number");
            string secondAnswer = Console.ReadLine();

            int first = Convert.ToInt32(answer);
            int second = Convert.ToInt32(secondAnswer);
            Console.WriteLine("the sum is- " + (first + second));
        }
        public static void catDog()
        {
            string cats = "cats";
            string dogs = "dogs";

            Console.WriteLine("cats or dogs?");


            string answer = Console.ReadLine();

            if (answer == cats)
            {
                Console.WriteLine("MEOW");
            }
            else if (answer == dogs)
            {
                Console.WriteLine("BARK");
            }
            Console.ReadKey();


        }
        public static void oddEvent()
        {
            int i;

            Console.WriteLine("Enter a number!");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("the number you have entered is Even");
                Console.Read();
            }
            else
            {
                Console.Write("the number you have entered is Odd");
                Console.Read();
            }

        }
        public static void inches()
        {
            Console.WriteLine("Enter a height in ft.");
        }
        public static void echo()
        {
            Console.WriteLine("Enter a word");
        }
        public static void killGrams()
        {
            Console.WriteLine("Enter a weight in pounds");
        }
        public static void date()
        {

        }
        public static void age()
        {
            Console.WriteLine("What year were you born?");
        }
        public static void guess()
        {
            Console.WriteLine("Guess a programming language?");
        }

    }
}
