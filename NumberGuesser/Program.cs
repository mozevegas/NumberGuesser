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
            // Randomizer
            Random rndTwo = new Random();
            int randomNumber = rndTwo.Next(0, 100);

            // Temporary gives the random number
            Console.WriteLine($"this is the random, shhhh {randomNumber}");

            // Inputs the guess
            Console.WriteLine("Please guess a # from 1-100");
            var yourGuess = int.Parse(Console.ReadLine());


            if (yourGuess == (randomNumber - 5))
            {
                Console.WriteLine("Minus the 5");
            }
            else if (yourGuess == randomNumber)
            {
                Console.WriteLine("condition 2");
            }
             
            else
            {
                Console.WriteLine("the key was 22");
            }
        }
    }
}
