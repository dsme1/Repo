using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculteiten
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            float number;

            Program p = new Program();
            Console.WriteLine("Voer een getal in om de faculteit van dit getal te krijgen. Om af te sluiten type je stop.");

            //gameloop requiring continuous user input
            while (userInput != "stop")
            {
                userInput = Console.ReadLine();

                bool succes = float.TryParse(userInput, out number);
                if (succes && number <= 34f)
                {
                    number = p.CalculateFactorial(number);
                    Console.WriteLine(number);
                }
                else if (!succes || number >= 35f)
                    Console.WriteLine("De gegeven input is geen nummer of een te groot getal om te berekenen.");
            }
            
        }

        //calculates the factorial up to 34 in userinput because of overflow.
        public float CalculateFactorial(float numberInput)
        {
            float fact;

            fact = numberInput;
            for (float i = numberInput - 1; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }
    }    
}
