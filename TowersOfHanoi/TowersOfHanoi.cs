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

        }
    }

    class Game
    {
        Dictionary<char, Tower> gameMaster = new Dictionary<char, Tower>();
        public Game ()
        {
            /* Tower A = new Tower();
            Tower B = new Tower();
            Tower C = new Tower();*/

           Stack<Block> towerA = new Stack<Block>();
           Stack<Block> towerB = new Stack<Block>();
           Stack<Block> towerC = new Stack<Block>();

           Block block1 = new Block(1);
           Block block2 = new Block(2);
           Block block3 = new Block(3);
           Block block4 = new Block(4);

           towerA.Push(block4);
           towerA.Push(block3);
           towerA.Push(block2);
           towerA.Push(block1);

            gameMaster.Add('A', towerA);
            gameMaster.Add('B', towerB);
            gameMaster.Add('C', towerC);

        }

        public Dictionary<Tower, Stack> DrawBoard()
        {
            Console.WriteLine(gameMaster);
            return;
        }

    }

    class Tower
    {
        Stack<Block> blocks = new Stack<Block>();
    }   

    class Block
    {
        public Block(int length)
        {
            this.length = length;
        }

        public int length
        {
            get;
            private set;
        }

    }



}


