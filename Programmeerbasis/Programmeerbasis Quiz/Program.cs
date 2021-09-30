using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeerbasis_Quiz
{
    class Program
    {       
        /// <summary>
        /// Quiz game for school assignment
        /// </summary>
        static void Main(string[] args)
        {
            //gets a random number from generator
            var generator = new RandomGenerator();
            var randomNumber = generator.RandomNumber(1, 100);

            Console.WriteLine(randomNumber);
            Console.WriteLine("Dit programma kiest een getal tussen 1 en 100. Raad het getal.");

            string userInput = "0";
            int guessNumber = int.Parse(userInput);
            var turns = 0;

            //the actual gameloop. it checks for the correct number continuously until found
            while (guessNumber != randomNumber)
            {
                //checks if the user wrote stop to terminate the program
                userInput = Console.ReadLine();
                if (userInput == "stop")
                {
                    Console.WriteLine("Het programma zal afsluiten.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }              
                
                guessNumber = int.Parse(userInput);
                
                //checks wether the number was correct, wrong or out of bounds
                if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Het nummer is lager.");
                }

                if (guessNumber < randomNumber)
                {
                    Console.WriteLine("Het nummer is hoger.");
                }

                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("Goed geraden, het nummer was inderdaad " + randomNumber + ". Je hebt er " + turns + " beurten over gedaan.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                if (guessNumber < 1)
                {
                    Console.WriteLine("Het programma zal afsluiten.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                if (guessNumber > 100)
                {
                    Console.WriteLine("Het programma zal afsluiten.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                turns++;
            }                
        }
    }

    /// <summary>
    /// Class for handling random number generation
    /// </summary>
    public class RandomGenerator
    {
        private Random random = new Random();

        public int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
