using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            string hand1 = GetInput();
            string hand2 = ComputerChoice();
            CompareHands(hand1, hand2);
            Console.ReadLine();
        }
        //Getting input from the User and validating it.
        public static string GetInput()
        {
            bool valid = false;
            string hand1 = null;

            Console.WriteLine("Enter hand 1:");
            hand1 = Console.ReadLine();
                //Input validation
                try
                {
                    ValidateHand(hand1);
                    valid = true;
                }
                
                catch
                {
                    //Automatic hand choosing if the player doesn't enter a valid entry
                    Console.WriteLine("There was a problem with your input.");
                    Console.WriteLine("Picking a hand for you...");

                }
              if (valid == true)
              {
                Console.WriteLine("Choosing hand 2...");
                return hand1;

              } else
              {
                  string hand2 = ComputerChoice();
                  return hand2;
              }
                
            

        }


        //hand validation with exception
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
        // Random hand2 choice by computer
        // this also is where the choice for the player is made (if input is invalid)
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
        
        //meat of the game. Where we get to hand comparison
        public static string CompareHands(string hand1, string hand2)
        {
            Console.WriteLine("You chose {0} and I chose {1}.", hand1, hand2);
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

