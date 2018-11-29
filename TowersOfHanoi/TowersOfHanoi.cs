using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // start a new game
            Game newGame = new Game();
            //draw the board
            newGame.DrawBoard();

        }
    }

    class Game
    {
        Dictionary<string, Tower> Towers = new Dictionary<string, Tower>();
        public Game()
        {
            Tower towerA = new Tower();
            Tower towerB = new Tower();
            Tower towerC = new Tower();


            Block block1 = new Block(1);
            Block block2 = new Block(2);
            Block block3 = new Block(3);
            Block block4 = new Block(4);

            towerA.Add(block4);
            towerA.Add(block3);
            towerA.Add(block2);
            towerA.Add(block1);

            Towers.Add("Tower A:", towerA);
            Towers.Add("Tower B:", towerB);
            Towers.Add("Tower C:", towerC);

        }

        public void DrawBoard()
        {
            
            foreach (KeyValuePair<string, Tower> entry in Towers)
            {
                
                Console.WriteLine("{0} {1}", entry.Key, entry.Value);
                Console.WriteLine();

            }
        }

    }

    class Tower
    {
        Stack<Block> blocks = new Stack<Block>();
        public void Add(Block aBlock)
        {
            blocks.Push(aBlock);
        }


        public string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

            
        }
       
       public override string ToString()
       {
           string weightString = " ";

            foreach(Block block in blocks)
            {
                weightString = weightString +" "+ block.weight;
            }
            String reversedString = ReverseString(weightString);
            return reversedString;

           
           
       }


    }

    class Block
    {
        public Block(int weight)
        {
            this.weight = weight;
        }

        public int weight
        {
            get;
            private set;
        }
        
    


    }


}


