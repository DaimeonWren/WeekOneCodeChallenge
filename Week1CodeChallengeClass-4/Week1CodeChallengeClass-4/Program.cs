using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallengeClass_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Yodazizer("I Like Code");
            TextStats("abcdefghijklmnopqrstuvwxyz");
            TextStats("HAHAHAHAHAHAHA dodosmfaspfmasdpfmad[fnasdoufhp9");
            for (int i = 1; i < 25; i++)
            {
                IsPrime(i);
            }
            DashInsert(8675309);
            
            Console.ReadKey();
        }

        static void FizzBuzz(int number)
        {

        }

        static void Yodazizer(string text)
        {
            List<string> words = text.Split(' ').ToList();

            string output = "";

            for (int i = words.Count - 1; i >= 0; i--)
            {
                output = output + words[i] + " ";
            }
            Console.WriteLine(output);
        }

        static void TextStats(string input)
        {
            int numChars = input.Length;
            int numWords = input.Split(' ').ToList().Count;
            int numVowels = 0;
            int numCons = 0;
            int numSpec = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // grab our current letter from the text
                string letter = input[i].ToString();
                if ("aeiou".Contains(letter.ToLower()))
                {
                    numVowels++;
                }
                else if (".,?".Contains(letter))
                {
                    numSpec++;
                }
                else
                {
                    numCons++;
                }

            }
            Console.WriteLine(input);
            Console.WriteLine("# Chars " + numChars);
            Console.WriteLine("# Words " + numWords);
            Console.WriteLine("# Vowels " + numVowels);
            Console.WriteLine("# Consonants " + numCons);
            Console.WriteLine("# Spec Chars " + numSpec);


        }

        static void IsPrime(int number)
        {
            // need to check all numbers in between 1 and itself to see if it is divisible by anything else
            // assume the number is prime until it isn't
            bool prime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    break; // escape the loop
                }
            }
            if (prime)
            {
                Console.WriteLine(number + " is prime");
            }

            else
            {
                Console.WriteLine(number);
            }
        }

        static void DashInsert(int number) 
        {
        // Goal Insert a dash between two odd numbers
            //decare a string to hold our number as a string
            string output = "";
            string numberString = number.ToString();
            //loop through each digit of our string
            for (int i = 0; i <= numberString.Length - 2; i++)
            {
                // get our current digit and the one next to it
                string num1String = numberString[i].ToString();
                string num2String = numberString[i + 1].ToString();
                //convert our numberStrings to actual numbers
                int num1 = int.Parse(num1String);
                int num2 = int.Parse(num2String);
                if (num1 % 2 != 0 && num2 % 2 != 0)
                {
                    // both odd, add to the output
                    output = output + num1 + "-";
                }
                else 
                {
                    output = output + num1;
                }
            }
          //need to add the last digits to our output, because the loop does not add it
            output = output + numberString[numberString.Length - 1];
            Console.WriteLine(output);
        }
    
    }
} 