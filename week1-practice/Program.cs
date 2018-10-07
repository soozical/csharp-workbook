using System;
using System.Threading;

namespace week1_practice
{
    class Program
    {
        static void Main(string[] args)
        {   
            addition();
            Thread.Sleep(1000);
            yardConversion();
            Thread.Sleep(1000);
            datatypes();
            Thread.Sleep(1000);
            personalInfo();
            Thread.Sleep(1000);
            //numConversion();
            Thread.Sleep(1000);
            mathProbs();
        }
        static void addition()
        {
            int x;
            int y;
            string placeholderX;
            string placeholderY;
            Console.WriteLine("Please enter an integer.");
            placeholderX = Console.ReadLine();
            x = int.Parse(placeholderX);
            Console.WriteLine("Please enter another integer.");
            placeholderY = Console.ReadLine();
            y = int.Parse(placeholderY);
            int z = x + y;
            Console.WriteLine("The sum of your integers is {0}.", z);
        }
        static void yardConversion()
        {
            float yards;
            float inches;
            string placeholderYards;
            //string placeholderInches;
            Console.WriteLine("Let's convert some yards to inches.");
            Thread.Sleep(1000);
            Console.WriteLine("Enter some yards.");
            Console.WriteLine("No need to enter a unit of measurement.");
            placeholderYards = Console.ReadLine();
            yards = float.Parse(placeholderYards);
            Console.WriteLine(yards * 36);

        }
        static void datatypes()
        {
            bool people = true;
            bool f = false;
            float num = 5.5f;
            Console.WriteLine(num * num);

        }

        static void personalInfo()
        {
            string firstName = "Susie";
            string lastName = "Odneal";
            byte age = 31;
            string favoriteBand  = "Elohim";
            string favoriteSports  = "Astros";
            Console.WriteLine("Hi, my name is {0}{1}.", firstName, " ", lastName);
            Console.WriteLine("I don't particularly like sports but I guess my favorite team is the {0}.", favoriteSports);



        }   
        /*static void numConversion()
        {
            var num = 3;
            int myInt = int.Parse(num);
            Console.WriteLine(myInt.GetType());

        }*/

        static void mathProbs()
        {
            float x = 10f;
            float y = 100f;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);

        }

    }
}
