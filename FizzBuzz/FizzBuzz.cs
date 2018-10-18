using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to Fizz Buzz");
            int input = Convert.ToInt32(Console.ReadLine());
            calcFizz(input);
            
        }

        static string calcFizz(int input) {
            string fizz = "Fizz";
            for(int i = 0; i < input; i++) {
                if(input % 3 == 0){
                    return fizz;
                } else {
                    input++;
                    string  inputStr = Convert.ToString(input);
                    return inputStr;
                }
                i++;
            }
        }    

    }
}
