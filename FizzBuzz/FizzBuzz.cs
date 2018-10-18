using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to Fizz Buzz");
             int input = Convert.ToInt32(Console.ReadLine());
            
                for (int i = 1; i <= input; i++)
                {
                    if(i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    } else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    } else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    } else 
                    {
                        Console.WriteLine(i);
                    }
                }


            }
        }


    }


