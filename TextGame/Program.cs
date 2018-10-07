using System;
using System.Threading;
namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int stick = 0;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(3000);
            Console.WriteLine("You enter a dark cavern out of curiosity.");
            Console.WriteLine("It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it? [Y/N]");
            string ch1 = Console.ReadLine();
            if(ch1 = 'Y')
            {
                Console.WriteLine("You have taken the stick!");
                stick = 1;
                Thread.Sleep(3000);
            } else {
                Console.WriteLine("You did not take the stick.");
                stick = 0;

            }
            Console.WriteLine("As you proceed further into the cave, you see a small glowing object.");
            Console.WriteLine("Do you approach the object? [Y/N]");
            string ch2 = Console.ReadLine();
            if (ch2 = 'Y')
            {
                Console.WriteLine("You approach the object...");
                Thread.Sleep(200);
                Console.WriteLine("The eye belongs to a giant spider!");
                Console.WriteLine("Do you try and fight it? [Y/N]");
                string ch3 = Console.ReadLine();
                if (ch3 = 'Y')
                {
                    if (stick > 0)
                    {
                        Console.WriteLine("You only have a stick to fight with!");
                        Console.WriteLine("You quickly jab the spider in it's eye and gain an advantage!");
                        Thread.Sleep(2000);
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("                  Fighting...                   ");
                        Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
                        Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    }
                }
            }
        }
    }
}
