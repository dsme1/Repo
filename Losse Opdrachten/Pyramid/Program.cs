using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;

            Console.WriteLine("Geef een getal op wat de hoeveelheid lagen van de piramide wordt.");
            userInput = int.Parse(Console.ReadLine());

            //draws a pyramid based on the userinput by instantiating new strings consecutively
            for (int height = 1; height <= userInput; height++)
            {
                Console.Write(new string(' ', userInput - height));
                Console.WriteLine(new string('*', height * 2 - 1)); 
            }

            Console.ReadKey();
        }
    }
}
