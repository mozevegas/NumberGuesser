using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rndTwo = new Random();
            int randomNumber = rndTwo.Next(0, 100);

            var guessMe = 22;
            Console.WriteLine($"this is the random, shhhh {randomNumber}");
            Console.WriteLine(guessMe);
            if (guessMe == 50)
            {
                Console.WriteLine("Correct number");
            }
            else if (guessMe == 48)
            {
                Console.WriteLine("number 48");
            }
             
            else
            {
                Console.WriteLine("the key was 22");
            }
        }
    }
}
