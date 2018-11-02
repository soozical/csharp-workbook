using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            bool validInput = false;
            string hand1 = null;
            string hand2 = ComputerChoice();



            while (hand1 == null)
            {
                try
                {
                    GetInput(hand1);
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine("There was a problem with your entry. Choosing your hand for you.");
                    string hand3 = HumanChoice();
                    Console.WriteLine(CompareHands(hand3, hand2));
                    validInput = false;
                }
                
                    ComputerChoice();
                    Console.WriteLine(CompareHands(hand1, hand2));
                


            }
            
        }

        public static string GetInput(string hand1)
        {
            Console.WriteLine("Enter hand 1:");
            hand1 = Console.ReadLine();
            if (hand1 == "rock" || hand1 == "paper" || hand1 == "scissors")
            {
                Console.WriteLine("Choosing hand 2...");
                string hand2 = ComputerChoice();
                return hand2;

            }
            else
            {
                
                hand1 = null;
                throw new Exception("Invalid Input");
                return hand1;
            }

           

        }

        public static string ComputerChoice()
        {
            Random r = new Random();
            int hand2Choice = r.Next(0, 2);

            if (hand2Choice == 0)
            {
                return "rock";
            }
            if (hand2Choice == 1)
            {
                return "paper";
            }
            if (hand2Choice == 2)
            {
                return "scissors";
            }
            else
            {
                throw new Exception("Bad Computer Choice");
            }

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
                if (hand2 == "scissors")
                {
                    Console.WriteLine("Hand one wins!");
                }
                else if (hand2 == "paper")
                {
                    Console.WriteLine("Hand two wins!");
                    //Console.WriteLine("Debug");
                }
            }
            //Paper branch
            if (hand1 == "paper")
            {
                if (hand2 == "rock")
                {
                    Console.WriteLine("Hand one wins!");
                }
                else if (hand2 == "scissors")
                {
                    Console.WriteLine("Hand two wins!");
                }
            }
            //Scissors branch
            if (hand1 == "scissors")
            {
                if (hand2 == "paper")
                {
                    Console.WriteLine("Hand one wins!");
                }
                else if (hand2 == "rock")
                {
                    Console.WriteLine("Hand two wins!");
                }
            }
            else
            {
                throw new Exception("Invalid Entry");
            }

            return hand1 + ' ' + hand2;
        }
        public static string HumanChoice()
        {

            Random r = new Random();
            int hand1Choice = r.Next(0, 2);

            if (hand1Choice == 0)
            {
                return "rock";
            }
            if (hand1Choice == 1)
            {
                return "paper";
            }
            if (hand1Choice == 2)
            {
                return "scissors";
            }
            else
            {
                throw new Exception("Bad Human Choice");
            }

        }
    }
}
