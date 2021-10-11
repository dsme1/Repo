using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grootheden
{
    class Program
    {
        static void Main(string[] args)
        {
            double userInput;
            string userInputString = "";
            double convertedValue;
            string userInputFrom;
            string userInputTo;
            bool badInput = true;
            bool hasLetters = true;
            distance from = distance.Meter;
            distance to = distance.Meter;

            //userinput loop to get a value. also checks the string for anything that isn't a digit
            Console.WriteLine("Geef een waarde om te converteren op.");
            while (hasLetters)
            {
                userInputString = Console.ReadLine();
                if (userInputString.All(char.IsDigit))
                    hasLetters = false;
            }

            //converts string to a double floatpoint
            userInput = Convert.ToDouble(userInputString);

            //userinput loop to get a value of a unit of measurement. won't accept any other answers than units of measurement.
            Console.WriteLine("Geef een grootheid van Kilometer tot Milimeter aan.");
            while (badInput)
            {
                userInputFrom = Console.ReadLine();
                switch (userInputFrom)
                {
                    case "Milimeter":
                        from = (distance)Enum.Parse(typeof(distance), userInputFrom);
                        badInput = false;
                        break;
                    case "Centimeter":
                        from = (distance)Enum.Parse(typeof(distance), userInputFrom);
                        badInput = false;
                        break;
                    case "Decimeter":
                        from = (distance)Enum.Parse(typeof(distance), userInputFrom);
                        badInput = false;
                        break;
                    case "Meter":
                        from = (distance)Enum.Parse(typeof(distance), userInputFrom);
                        badInput = false;
                        break;
                    case "Decameter":
                        from = (distance)Enum.Parse(typeof(distance), userInputFrom);
                        badInput = false;
                        break;
                    case "Hectometer":
                        from = (distance)Enum.Parse(typeof(distance), userInputFrom);
                        badInput = false;
                        break;
                    case "Kilometer":
                        from = (distance)Enum.Parse(typeof(distance), userInputFrom);
                        badInput = false;
                        break;
                    default:
                        Console.WriteLine("Vul een grootheid in.");
                        break;
                }
            }

            //resets badinput to true for next loop
            badInput = true;

            //userinput loop to get a value of a unit of measurement. won't accept any other answers than units of measurement.
            Console.WriteLine("Geef een gewenste grootheid van Kilometer tot Milimeter om naartoe te converteren.");
            while (badInput)
            {
                userInputTo = Console.ReadLine();
                switch (userInputTo)
                {
                    case "Milimeter":
                        to = (distance)Enum.Parse(typeof(distance), userInputTo);
                        badInput = false;
                        break;
                    case "Centimeter":
                        to = (distance)Enum.Parse(typeof(distance), userInputTo);
                        badInput = false;
                        break;
                    case "Decimeter":
                        to = (distance)Enum.Parse(typeof(distance), userInputTo);
                        badInput = false;
                        break;
                    case "Meter":
                        to = (distance)Enum.Parse(typeof(distance), userInputTo);
                        badInput = false;
                        break;
                    case "Decameter":
                        to = (distance)Enum.Parse(typeof(distance), userInputTo);
                        badInput = false;
                        break;
                    case "Hectometer":
                        to = (distance)Enum.Parse(typeof(distance), userInputTo);
                        badInput = false;
                        break;
                    case "Kilometer":
                        to = (distance)Enum.Parse(typeof(distance), userInputTo);
                        badInput = false;
                        break;

                    default:
                        Console.WriteLine("Geef een grootheid aan.");
                        break;
                }
            }

            //prints out converted value
            convertedValue = ConvertDistance(userInput, ConversionRate(from, to), from , to);
            Console.WriteLine(convertedValue);

            Console.ReadKey();
        }        

        public enum distance
        {
            Milimeter,
            Centimeter,
            Decimeter,
            Meter,
            Decameter,
            Hectometer,
            Kilometer
        }

        /// <summary>
        /// Converts distance based on values given by user to anything between Milimeters to Kilometers
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="conversionRate"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        private static double ConvertDistance(double userInput, double conversionRate, distance from, distance to)
        {
            double convertedValue = userInput;
            if (from < to)
            {
                for (int i = 0; i < conversionRate; i++)
                {
                    convertedValue = convertedValue / 10;
                }
            }
            else
            {
                for (int i = 0; i < conversionRate; i++)
                {
                    convertedValue = convertedValue * 10;
                }
            }
            return convertedValue;
        }

        /// <summary>
        /// Calculates number of steps to convert between units of measurement. Example: Milimeter to Meter = 3 steps
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        private static double ConversionRate(distance from, distance to)
        {
            int numberFrom = Convert.ToInt32(from);
            int numberTo = Convert.ToInt32(to);
            double conversionRate = 0;

            if (from < to)
            {
                for (int i = numberFrom; numberFrom < numberTo; i++)
                {
                    numberFrom++;
                    conversionRate++;
                }
            }else
            {
                for (int i = numberFrom; numberFrom > numberTo; i--)
                {
                    numberFrom--;
                    conversionRate++;
                }
            }            

            return conversionRate;
        }
    }
}
