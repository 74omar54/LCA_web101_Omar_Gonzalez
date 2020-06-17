using System;

namespace ToDoItem
{
    class MainClass
    {
        public static void Main()
        {
            string answer;
            string todoItem;
            Console.WriteLine("Would you like to add an item? Yes or No ");
            answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("what is the description, due date, and priority of the item?");
                todoItem = Console.ReadLine();


            }
            else
            {
                Console.WriteLine("goodbye");
            }

        }
        public class Todo
        {
            string Description;
            int DueDate;
            string Priority;

            public 
            
        }
    }
}
