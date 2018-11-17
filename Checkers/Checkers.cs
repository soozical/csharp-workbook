using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class Checker
    {

        //Opened or closed dot
        public string Symbol  { get; set; }

        //Where the game piece is on the board
        public int[] Position  { get; set; }

        //the team color
        public string Color { get; set; }
        
        public Checker(string color, int[] position)
        {
            int openCircleID = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
            string openCircle = char.ConvertFromUtf32(openCircleID);

            int closedCircleID = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
            string closedCircle = char.ConvertFromUtf32(closedCircleID);

            if(color == "white")
            {
                Symbol = openCircle;
            }
            else
            {
                Symbol = closedCircle;
            }


        }
    }

    public class Board
    {

        // The grid that makes up the board
        public string[][] Grid  { get; set; }

        //collection of checkers currently on the board
        public List<Checker> Checkers { get; set; }
        
        public Board()
        {
             
            CreateBoard();
            DrawBoard();
            return;
        }

        // Creating the grid that is the board        
        public void CreateBoard()
        {
            char[] rows = new char[7];
            char[] columns = new char[7];
            return;

        }
        
        //make game pieces
        public void GenerateCheckers()
        {
            // Your code here
            return;
        }
        
        //place game pieves
        public void PlaceCheckers()
        {
            // Your code here
            return;
        }

        //view game board        
        public void DrawBoard()
        {

            foreach(char entry in rows) 
            {
                Console.Write(rows);
            }
            foreach(char entry in columns)
            {
                Console.WriteLine(columns);
            }
            return;
        }
        
        //selects a particular checker
        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }
        
        //removing a defeated game piece
        public void RemoveChecker(int row, int column)
        {
            // Your code here
            return;
        }

        //check if all checkers of one color have been removed        
        public bool CheckForWin()
        {
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }
    }


    class Game
    {
        public Game()
        {
            // Your code here
        }
    }
}
