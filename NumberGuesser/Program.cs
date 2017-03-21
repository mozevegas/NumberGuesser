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
            var yourGuess = 0;
            var wasSuccessful =  int.TryParse(Console.ReadLine(), out yourGuess);

            // temporary testing -tester needs to be false for it to work
            bool tester = true;

            int counter = 0;

            var guessArray = new int[5];

            while ((yourGuess != randomNumber) && counter < 4)
            {
                if (yourGuess < randomNumber)
                {
                    guessArray[counter] = yourGuess;
                    // test array for input
                    Console.WriteLine($"array contains { guessArray[counter]} ");
                    Console.WriteLine("You are too low, guess again...");
                    yourGuess = 0;
                    wasSuccessful = int.TryParse(Console.ReadLine(), out yourGuess);
                    counter ++;
                }
                if (yourGuess > randomNumber)
                {
                    guessArray[counter] = yourGuess;
                    // test array for input
                    Console.WriteLine($"array contains { guessArray[counter]} ");
                    Console.WriteLine("That is TOO HIGH, guess again...");
                    yourGuess = 0;
                    wasSuccessful = int.TryParse(Console.ReadLine(), out yourGuess);
                    counter++;
                }
            }

            if (yourGuess == randomNumber)
            {
                Console.WriteLine($"You have Guessed {randomNumber} correctly. Have a nice day");
            }
            else
            {
                Console.WriteLine($"Your guess was not {randomNumber}. You lose.");
            }
            
        }
    }
}
