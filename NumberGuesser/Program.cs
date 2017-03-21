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


            for (int i=1; i < 5; i++)
            {
                if (yourGuess < (randomNumber))
                {
                    Console.WriteLine("tooooo lOw guess again please");
                    yourGuess = 0;
                    wasSuccessful = int.TryParse(Console.ReadLine(), out yourGuess);

                }
                else if (yourGuess > randomNumber)
                {
                    Console.WriteLine("toooo HIGH guess again if you don't mind");
                    yourGuess = 0;
                    wasSuccessful = int.TryParse(Console.ReadLine(), out yourGuess);
                }

                else if (yourGuess == randomNumber)
                {
                    Console.WriteLine("----YOU ARE CORRECT!!!------");
                    i = 5;
                }

                
            }
            if (yourGuess != randomNumber)
                {
                Console.WriteLine("you were unable to guess correctly, goodbye");
            }
            
        }
    }
}
