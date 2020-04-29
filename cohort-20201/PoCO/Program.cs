using System;

namespace PoCO
{
    class MainClass
    {
        public static void Main()
        {
            License myLicense = new License("Omar", "Gonzalez", "male", 33600358);
            Console.WriteLine(myLicense.WhatsMyName());
            Console.WriteLine("DL Number: " + myLicense.DlNumber);

            Book myBook = new Book("Harry potter and the Half Blood Prince", "J.K. Rowling", 652);
            Console.WriteLine(myBook.AboutBook());

            Airplane myAirplane = new Airplane("Boeing", "727", 350);
            Console.WriteLine(myAirplane.Airplaneinfo());
        }
    }
    public class License
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int DlNumber { get; set;  }

        public License(string firstName1, string lastName1, string gender1, int dlNum)
        {
            FirstName = firstName1;
            LastName = lastName1;
            Gender = gender1;
            DlNumber = dlNum;
        }
        public string WhatsMyName()
        {
            return FullName = FirstName + " " + LastName;
        }

        
        
    }
    public class Book
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public int Pages { get; set; }
        public string Sku { get; set; }
        public string Publisher { get; set; }
        public int Price { get; set; }

        public Book(string title1, string authors1, int pages1)
        {
            Title = title1;
            Authors = authors1;
            Pages = pages1;
            
        }
        public string AboutBook()
        {
            return Title + "Written by " + Authors + " contains " + Pages + "pages.";
        }
    }
    public class Airplane
    {
            public string Maufacturer { get; set; }
            public string Model { get; set; }
            public string Variant { get; set; }
            public int Capacity { get; set; }
            public int Engines { get; set; }

            public Airplane(string manufacturer1, string model1, int capacity1)
            {
                Maufacturer = manufacturer1;
                Model = model1;
                Capacity = capacity1;
            }
            public string Airplaneinfo()
            {
                return Maufacturer + " Model is " + Model + " Has the capacity to seat " + Capacity + " people ";
            }


    }
}
