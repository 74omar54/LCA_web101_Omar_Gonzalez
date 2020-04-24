using System;

namespace Gradebook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name = string.Empty;
            string answer = string.Empty;
            System.Collections.Generic.Dictionary<string, string> gradeBook = new System.Collections.Generic.Dictionary<string, string>();

            do
            {
                Console.WriteLine("Enter the student name.");
                name = Console.ReadLine();
                Console.WriteLine("Enter the students grades");
                string grades = Console.ReadLine();


                gradeBook.Add(name, grades);

                Console.WriteLine("Do you want to add another student? Enter quit to stop");
                answer = Console.ReadLine().ToLower();

            } while (!answer.Equals("quit"));

            int lowestGrade = 0;
            int highestGrade = 0;
            double average = 0.00;
            foreach (var item in gradeBook)
            {
                Console.WriteLine($"{item.Key}\n");

                int[] singleGrades = Array.ConvertAll<string, int>(gradeBook[item.Key].Split(), Convert.ToInt32);

                lowestGrade = singleGrades.Min();
                highestGrade = singleGrades.Max();
                average = singleGrades.Average();

                Console.WriteLine($"Highest grade = {highestGrade} Lowest grade = {lowestGrade} Average = {average}");
            }
        }

    }
}
