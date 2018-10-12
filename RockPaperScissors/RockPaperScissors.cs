using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            //Tie branch
            if (hand1 == hand2)
            {
                Console.WriteLine("It's a tie!");
            }
            if (hand1 == "rock")
            {
                if(hand2 == "scissors")
                {
                    Console.WriteLine("Hand one wins!");
                }
                else if(hand2 == "paper")
                {
                    Console.WriteLine("Hand two wins!");
                    //Console.WriteLine("Debug");
                }
            }
            //Paper branch
            if(hand1 =="paper")
            {
                if(hand2 == "rock")
                {
                    Console.WriteLine("Hand one wins!");
                }
                else if(hand2 == "scissors")
                {
                    Console.WriteLine("Hand two wins!");
                }
            }
            //Scissors branch
            if (hand1 == "scissors")
            {
                if(hand2 == "paper")
                {
                    Console.WriteLine("Hand one wins!");
                }
                else if(hand2 == "rock")
                {
                    Console.WriteLine("Hand two wins!");
                }
            }
            
            return hand1 + ' ' + hand2;
        }
    }
}
