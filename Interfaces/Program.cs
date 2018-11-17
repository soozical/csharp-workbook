using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Fox redFox = new Fox(true, 4, "red");
            Chicken leghorn = new Chicken(false, 2, "white");

        }
    }

    public interface IAnimal
    {
        bool isCarnivore();
        int numberOfLegs();

        string color();
        
    }

    public class Fox : IAnimal
    {
        public bool food;
        public int legs;
        public string getColor;
        public Fox(bool isCarnivore,int numberOfLegs, string color)
        {
            this.food = isCarnivore;
            this.legs = numberOfLegs;
            this.getColor = color;
            
        }

        public string color(string getColor)
        {
            return getColor;
        }
        public int numberOfLegs(int legs)
        {
            return legs;
        }

        public bool isCarnivore(bool food)
        {
            return food;
        }
    }

    public class Chicken : IAnimal
    {

        public bool food;
        public string getColor;
        public int legs;
        public Chicken(bool isCarnivore, int numberOfLegs, string color)
        {
            this.food = isCarnivore;
            this.legs = numberOfLegs;
            this.getColor = color;
        }
        
    }
}

