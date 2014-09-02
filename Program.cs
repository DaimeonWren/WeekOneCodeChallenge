using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            { 
                // don't know how to run both for loops at th same time, but i do know they work, i would have to delete one of the for loops.
                FizzBuzz(i);
            }

           for (int i = 92; i >= 79; i--)
            {
                FizzBuzz(i);
            }
           Yodaizer("I like code");

            Console.ReadKey();
        }

        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {

                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(number);
            }



        }

        static void Yodaizer(string text)
        {

            List<string> looseGoose = text.Split(' ').ToList();
           // i create a list of strings and split the text where there are spaces then .Tolist
             List<string> Re = new List<string>();
            // i create an empty sting within Re so i may add anything i'd like
            bool isThree = looseGoose.Count == 3;
            // the word count of looseGoose is 3 

            if (isThree)
           // Then create an "if" statement for the bool
            {
               //I use the .Add method to the rearange the text with index[]
                Re.Add(looseGoose[2]);
                Re.Add(looseGoose[0]);
                Re.Add(looseGoose[1]);
            }
                // Then create an else statement for a "for" loop to run the code through it backward
            else 
            // opptional else statement if 
            {
                for (int i = looseGoose.Count - 1; i >= 0; i--)
                {
                   //looseGoose.count
                    Re.Add(looseGoose[i]);
                    // 
                     
                    {
                        
                    }
                }
                
            }
            string output = string.Join(" ", Re);
            Console.WriteLine(output);
        }
    }
}
