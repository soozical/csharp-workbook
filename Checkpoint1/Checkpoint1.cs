using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            DivideBy3();
            CountNumbers();
            Factorial();
            RandomNumbers();
            MaxiumumNumbers();


            Console.WriteLine();
        }

        static void DivideBy3()
        {
            //Start sum at 0...
            int sum = 0;
            //...start counting at 1, and continue until 100.
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum++;

                }

            }
            Console.WriteLine("There are {0} numbers between 1 and 100 that are divisible by 3.", sum);
        }

        static void CountNumbers()
        {
            bool done = false;
            double total = 0.0;
            Console.WriteLine("Enter a whole number. Enter 'ok' to exit.");

            //While we're still counting...
            while (!done)
            {

                string input = Console.ReadLine();
                //exit if ok and print total
                if (input == "ok")
                {
                    Console.WriteLine("Exiting...");
                    Console.WriteLine("{0} was your total.", total);

                    return;
                }
                //or add up the numbers that are being entered.
                else
                {

                    double x = double.Parse(input);
                    total = x + total;

                }
            }
        }

        static void Factorial()
        {
            int total = 1;
            Console.WriteLine("Please enter a whole number.");
            int num = Convert.ToInt32(Console.ReadLine());
            //count backwards from num while doing factorial math
            for (int i = num; i > 0; i--)
            {
                //Console.WriteLine(i);
                total = total * i;


            }
            //print out totals
            Console.WriteLine("{0}!={1}", num, total);




        }
        static void RandomNumbers()
        {
            //establish random number
            Random r = new Random();
            int secret = 0;
            int tries = 1;
            int guess = 0;
            secret = r.Next(1, 10);
            Console.WriteLine("Guess the secret number by entering a whole number from 1 - 10.");
            Console.WriteLine("Secret number is {0}", secret);
            guess = Int32.Parse(Console.ReadLine());
            //while the guess is anything other than the secret number...
            while (guess != secret)
            {
                //if user has used up all their tries, they lose
                if(tries == 4)
                {
                    Console.WriteLine("Sorry, you lost.");
                    return;
                }
                //if they haven't used up all their tries, but still haven't gotten the number, 
                //give them another chance
                if (tries < 4 && guess != secret)
                {
                    Console.WriteLine("Incorrect! That was try {0} out of 4.", tries);
                    Console.WriteLine("Try again:");
                    guess = Int32.Parse(Console.ReadLine());
                    tries++;

                }
                

            }
            //If they guess the number, they win!
            if(guess == secret)
                {
                    Console.WriteLine("You won!");
                    return;
                }

        }

        static void MaxiumumNumbers()
        {
            Console.WriteLine("Please enter a some numbers, separated by a comma. I'll sort them for you.");
            Console.WriteLine("Example: 4, 7, 2, 3");
            //read the input
            string input = Console.ReadLine();
            //split input based on , and space
            string[] convertInput = input.Split(", ");
            //convert input to int
            int[] nums = Array.ConvertAll(convertInput, int.Parse);
            //sort and write the largest int
            Array.Sort(nums);
            Console.WriteLine(nums[nums.Length - 1]);
        }



    }
}
