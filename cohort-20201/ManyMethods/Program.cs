using System;

namespace ManyMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Addition();
            CatDog();
            OddEvent();
            Inches();
            Echo();
            KillGrams();
            Date();
            Age();
            Guess();




        }

        public static void Hello()
        {
            Console.WriteLine("What is your name?");
            Console.ReadLine();
            Console.WriteLine("Bye Bob");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public static void Addition()
        {
            Console.WriteLine("Enter your first number");
            string answer = Console.ReadLine();
            Console.WriteLine("Enter your second number");
            string secondAnswer = Console.ReadLine();

            int first = Convert.ToInt32(answer);
            int second = Convert.ToInt32(secondAnswer);
            Console.WriteLine("the sum is " + (first + second));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public static void CatDog()
        {
            string cats = "cats";
            string dogs = "dogs";

            Console.WriteLine("cats or dogs?");


            string answer = Console.ReadLine().ToLower();

            if (answer == cats)
            {
                Console.WriteLine("MEOW");
            }
            else if (answer == dogs)
            {
                Console.WriteLine("BARK");
            }
            else
            {
                Console.WriteLine("Must choose cats or dogs");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


        }

        public static void OddEvent()
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
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            //Need to find a way to restart the process of cats and dogs if somebody enters somehting rather than cats or dogs.
            

        }

        public static void Inches()
        {
            double inch;
            Console.WriteLine("Enter a height in ft.");
            double feet = Convert.ToDouble(Console.ReadLine());
            inch = feet * 12;
            Console.WriteLine("{0} Feet : {1} Inches", feet, inch);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        public static void Echo()
        {
            Console.WriteLine("Enter a word");
            string answer = Console.ReadLine();

            Console.WriteLine(answer.ToUpper());
            Console.WriteLine(answer.ToLower());
            Console.WriteLine(answer.ToLower());
            Console.Read();


       
        }

        public static void KillGrams()
        {
            Console.WriteLine("Enter a weight in pounds");
            double pounds = Convert.ToDouble(Console.ReadLine());

            double kilograms = pounds * 0.45359237; //This is the conversion rate of pounds to killograms.
            Console.WriteLine(pounds +  " Pounds is "  +  kilograms  +  " killograms");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        public static void Date()
        {
            Console.WriteLine("The current date and time is " + DateTime.Now);
            Console.Read();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public static void Age()
        {
            Console.WriteLine("What year were you born?");
            string answer = Console.ReadLine();


            int year = Convert.ToInt32(answer);
            int DOB = 2020 - year;

            Console.WriteLine("Your age is " + DOB);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            

           
        }

        public static void Guess()
        {
            string csharp = "csharp";

            Console.WriteLine("I am thinking of a programming language, what is it?");

            string answer = Console.ReadLine().ToLower();

            if (answer == csharp)
            {
                Console.WriteLine("CORRECT");
            } else
            {
                Console.WriteLine("WRONG");
            }

            Console.WriteLine("You made it all the way to the bottom without breaking me CONGRATS!!!");
           
         

        }

    }
}
