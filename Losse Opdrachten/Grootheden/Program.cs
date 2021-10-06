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
            string userInputFrom;
            string userInputTo;
            distance from;
            distance to;

            Console.WriteLine("Geef een waarde om te converteren op.");
            userInput = double.Parse(Console.ReadLine());

            Console.WriteLine("Geef een grootheid van Kilometer tot Milimeter aan.");
            userInputFrom = Console.ReadLine();
            from = (distance)Enum.Parse(typeof (distance), userInputFrom);

            Console.WriteLine("Geef een gewenste grootheid van Kilometer tot Milimeter");
            userInputTo = Console.ReadLine();
            to = (distance)Enum.Parse(typeof(distance), userInputFrom);



            Console.ReadKey();
        }

        //private static bool Convert(double userInput, distance from, distance to)
        //{
        //    double value;
        //
        //
        //}

        private static double[] conversionRate = new double[]
        {
            0.001, //Milimeter
            0.01, //Centimeter
            0.1, //Decimeter
            1, //Meter
            10, //Decameter
            100, //Hectometer
            1000 //Kilometer
        };

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
    }
}
