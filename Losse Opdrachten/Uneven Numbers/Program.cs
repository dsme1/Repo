using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uneven_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool stop = false;

            //userinput loop that determines wether the number given by user is even or uneven using the modulo of 10 to get the last digit of a number
            while (stop == false)
            {
                Console.WriteLine("Voer een getal in om te kijken of deze even of oneven is.");
                userInput = Console.ReadLine();

                if (userInput != "stop")
                {
                    int userValue = Int32.Parse(userInput);
                    userValue = userValue % 10;

                    if (userValue == 1 || userValue == 3 || userValue == 5 || userValue == 7 || userValue == 9)
                        Console.WriteLine("Uw getal is oneven.");
                    else
                        Console.WriteLine("Uw getal is niet oneven.");
                }
                else if (userInput == "stop")
                    stop = true;
                else
                    Console.WriteLine("U moet een nummer invoeren.");                
            }

            if (stop == true)
                Environment.Exit(0);
        }
    }
}
