using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leeftijdsgrens
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int age = 0;
            bool hasLetters = true;

            //userinput loop that checks for letters in the string
            Console.WriteLine("Geef uw leeftijd op.");
            while (hasLetters)
            {
                userInput = Console.ReadLine();
                if (userInput.All(char.IsDigit))
                    hasLetters = false;
                Int32.TryParse(userInput, out age);
            }

            //checks wether the user is either younger than 9 or older than 118
            if (age <= 9)
            {
                Console.WriteLine("U bent jonger dan 9. Het programma sluit af.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (age >= 118)
            {
                Console.WriteLine("U bent ouder dan 118. Het programma sluit af.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            //congratulates user if a certain age, warns at 62 and defaults to showing their age 
            //switches combineren controleren c#
            switch (age)
            {
                case 10:
                    Console.WriteLine("Gefeliciteerd u bent " + age + " oud.");
                    break;
                case 16:
                    Console.WriteLine("Gefeliciteerd u bent " + age + " oud.");
                    break;
                case 18:
                    Console.WriteLine("Gefeliciteerd u bent " + age + " oud.");
                    break;
                case 50:
                    Console.WriteLine("Gefeliciteerd u bent " + age + " oud.");
                    break;
                case 62:
                    Console.WriteLine("Het duurt nog 5 jaar voordat u 67 bent.");
                    break;
                case 67:
                    Console.WriteLine("Gefeliciteerd u bent " + age + " oud.");
                    break;
                case 100:
                    Console.WriteLine("Gefeliciteerd u bent " + age + " oud.");
                    break;
                default:
                    Console.WriteLine("U bent " + age + " Jaar oud. Het programma zal nu afsluiten.");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
