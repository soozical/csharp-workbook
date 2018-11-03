using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            string hand1 = GetInput();
            string hand2 = AutomatedChoice();
            CompareHands(hand1, hand2);
        }

        public static string GetInput()
        {
            bool valid = false;
            string hand1 = null;

            Console.WriteLine("Enter hand 1:");
            hand1 = Console.ReadLine();
            
                try
                {
                    ValidateHand(hand1);
                    return hand1;
                }
                catch
                {
                    Console.WriteLine("There was a problem with your input.");
                    Console.WriteLine("Picking a hand for you...");
                    string hand3 = AutomatedChoice();

                }
            Console.WriteLine("Choosing hand 2...");
                string hand2 = AutomatedChoice();
                Console.WriteLine("You chose {0} and I chose {1}.", hand1, hand2);
                CompareHands(hand1, hand2);
        }

        public static string ValidateHand(string hand)
        {
            if (hand == "rock" || hand == "paper" || hand == "scissors")
            {
                return hand;
            }
            else
            {
                throw new Exception("invalid input");
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

                throw new Exception("Bad computer choice");
            }

        }
        public static string AutomatedChoice()
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

            return hand1 + ' ' + hand2;
        }

    }
}

