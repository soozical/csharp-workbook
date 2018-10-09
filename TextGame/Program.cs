using System;
using System.Threading;
namespace TextGame
{
    class Program
    {   
        static void Main(string[] args)
        {   int complete = 0;
            int stick = 0;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(3000);

            //Begin, finding stick choice
            Console.WriteLine("You enter a dark cavern out of curiosity.");
            Console.WriteLine("It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it? [Y/N]");
            string ch1 = Console.ReadLine();
            if(ch1 == "Y")
            {
                Console.WriteLine("You have taken the stick!");
                stick = 1;
                Thread.Sleep(3000);
            } else {
                Console.WriteLine("You did not take the stick.");
                stick = 0;

            }
            //find spider
            Console.WriteLine("As you proceed further into the cave, you see a small glowing object.");
            Console.WriteLine("Do you approach the object? [Y/N]");
            string ch2 = Console.ReadLine();
            
            if (ch2 == "Y")
            {
                Console.WriteLine("You approach the object...");
                Thread.Sleep(200);
                
                Console.WriteLine("The eye belongs to a giant spider!");
                Console.WriteLine("Do you try and fight it? [Y/N]");
                string ch3 = Console.ReadLine();
                
                
                if (ch3 == "Y")
                {   
                    //Fight with stick
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
                        Thread.Sleep(2000);
                        
                        Random fdmg1 = new Random(); 
                        Random edmg1 = new Random();
                        int fdmg2 = fdmg1.Next(3, 11);
                        int edmg2 = edmg1.Next(1, 6);
                        
                        Console.WriteLine("you hit a {0}.", fdmg2);
                        Console.WriteLine("the spider hits a {0}.", edmg2);
                        Thread.Sleep(2000);
                        
                        if(edmg2 > fdmg2)
                        {
                            Console.WriteLine("The spider has dealt more damage than you!");
                            complete = 0;
                            return;
                        }
                        
                        if(fdmg2 < 5){
                            Console.WriteLine("You didn't do enough damage to kill the spider, but you manage to escape");
                            complete = 1;
                            return;
                        }

                        else
                        {
                            Console.WriteLine("You killed the spider!");
                            complete = 1;
                            return;
                        }
                                 
                        
                    }
                    
                    //Fight without stick
                    
                    else
                    {
                        Console.WriteLine("You don't have anything to fight with!");
                        Thread.Sleep(2000);
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("                  Fighting...                   ");
                        Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
                        Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Thread.Sleep(2000);
                        

                        Random fdmg1 = new Random(); 
                        Random edmg1 = new Random();
                        int fdmg2 = fdmg1.Next(1, 9);
                        int edmg2 = edmg1.Next(1, 6);
                        Console.WriteLine("you hit a {0}.", fdmg2);
                        Console.WriteLine("the spider hits a {0}", edmg2);
                        Thread.Sleep(2000);
                        
                        if(edmg2 > fdmg2)
                        {
                            Console.WriteLine("The spider has dealt more damage than you!");
                            complete = 0;
                            return;
                        }
                        
                        if(fdmg2 < 5)
                        {
                            Console.WriteLine("You didn't do enough damage to kill the spider, but you manage to escape");
                            complete = 1;
                            return;
                        }
                        
                        else
                        {
                            Console.WriteLine("You killed the spider!");
                            complete = 1;
                        
                        }

                    }   
                
                }

            }
            
            //Don't approach Spider
            else
            {
                Console.WriteLine("You turn away from the glowing object, and attempt to leave the cave...");
                Thread.Sleep(1000);
                Console.WriteLine("But something won't let you...");
                Thread.Sleep(2000);
                complete = 0;
            }
            //Game Loop
            /* bool alive = true;
            while (alive == true)
            {
                if (complete == 1)
                {
                    Console.WriteLine("You managed to escape the cavern alive! Would you like to play again? Y/N");
                    string replay = Console.ReadLine();
                    if(replay == "Y")
                    {
                        alive = true;
                    }
                    else
                    {
                     break;
                    }
                }
                else
                {
                    Console.WriteLine("You have died! Would you like to play again? Y/N");
                    string replay = Console.ReadLine();
                    if (replay == "Y")
                    {
                        alive = true;
                    }
                    else
                    {
                        break;
                    }

                }
            }*/
        }
    }
}
