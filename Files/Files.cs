using System;
using System.IO;
using System.Linq;


namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string magicWord = GetWord();
            //Debug getting word
            Console.WriteLine(magicWord);

            int guesses = Game(magicWord);
            Guessing(magicWord, guesses);

        }


        //generate magic word from file
        static string GetWord()
        {
            //File location, and read all lines into the program
            String file = @"words_alpha.txt";
            String[] words = File.ReadAllLines(file);

            //generate random int index and find it in the array
            Random rnd = new Random();
            int index = rnd.Next(1, (words.Length - 1));

            //return the string representation of index
            String wordIndex = words[index];
            return wordIndex;
        }

        static int Game(String magicWord)
        {
            //converst the letters into an array so we can count them
            char[] letters = magicWord.ToCharArray();
            int guesses = letters.Length + 4;
            //tell the user the rules of the game
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine();
            Console.WriteLine("The word has " + letters.Length + " letters and you have " + guesses + " guesses.");
            return guesses;
        }

        static void Guessing(String magicWord, int guesses)
        {
            char[] letters = magicWord.ToCharArray();
            //while we still have guesses left...
            while (guesses > 0)
            {
                //keep asking for guesses
                Console.WriteLine();
                Console.WriteLine("Enter your guess.");
                string guess = Console.ReadLine();
                char[] guessArray= guess.ToCharArray();
                char result = guessArray[0]; 
                if (magicWord.Contains(guess))
                {
                    Console.WriteLine("Correct!");
                    
                    for(int i = 0; i < letters.Length; i++)
                    {

                        if(result == letters[i])
                        {
                            Console.WriteLine(guess);
                        }
                        else
                        {
                            Console.WriteLine("_");
                        }
                    }



                }
                //if wrong, you get one less guess
                else
                {
                    guesses--;
                    Console.WriteLine("Incorrect. You have " + guesses + " remaining.");
                }

            }
            //Game over.
            if(guesses == 0 )
            {
                Console.WriteLine("Sorry, game over.");
                Console.WriteLine();
            }


        }

    }
}
