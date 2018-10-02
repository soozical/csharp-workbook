using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) {
           string name = " ";
           int age;
           string nameOfPet = " ";

        Console.WriteLine("Hi! What's your name?");
        name = Console.ReadLine();
        Console.WriteLine("Nice name. How old are you?");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cool. I was born on October 1st, 2018.");
        Console.WriteLine("What's the name of your pet?");
        nameOfPet = Console.ReadLine();

        Console.WriteLine("Cute!");
        Console.WriteLine("Your name is {0}, you are {1} years old, and your pet's name is {2}!", name, age, nameOfPet);

        }
        
    }
}
