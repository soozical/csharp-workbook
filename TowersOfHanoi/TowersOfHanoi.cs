using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
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

       
       public override string ToString()
       {
           foreach(Block Block in blocks){
            Console.WriteLine(Block.length);

           }
           
           
       }


    }

    class Block
    {
        int weight;
        public Block(int weight)
        {
            string myLength = weight.ToString();
            this.weight = weight;
        }

        public override string ToString()
        {
            return myWeight;
        }

        public string myWeight
        {
            get;
            private set;
        }
        public int weight
        {
            get;
            private set;
        }
        
    


    }



}


