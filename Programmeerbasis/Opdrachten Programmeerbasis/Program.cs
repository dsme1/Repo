using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_Programmeerbasis
{
    class Program
    {

        public void TestFunction()
        {
            Console.WriteLine("Deze regel is in een function uitgevoerd.");
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            int getal1 = 15;
            int getal2 = 3;
            int opsomming = getal1 + getal2;
            int verschil = getal1 - getal2;
            int product = getal1 * getal2;
            int quotient = getal1 / getal2;
            int rest = getal1 % getal2;

            int teller = 8;
            int maximum = 15;

            int tafel;

            string userInput = "";

            string stop = "nee";

            string hoi = "Hello World! Regel erbij gevoegd vanwege opdracht.";

            string naam = "";
            int leeftijd;

            string[] weekdagen = {"Zondag", "Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag"};

            while(teller <= 13)
            {
                Console.WriteLine(hoi);
                teller++;
            }

            Console.WriteLine(opsomming);
            Console.WriteLine(verschil);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
            Console.WriteLine(rest);

            Console.WriteLine("Teller is voor de While lus.");
            teller = 0;
            while (stop == "nee")
            {
                Console.WriteLine("Teller is: " + teller);
                Console.WriteLine("Wil je stoppen?");
                stop = Console.ReadLine();
                teller++;
            }

            for (teller = 0; teller <=maximum; teller++)
            {
                Console.WriteLine(hoi);
            }

            Console.WriteLine("Geef een woord of zin op.");
            userInput = Console.ReadLine();
            Console.WriteLine("Dit was jouw zin/woord: " + userInput);

            Console.WriteLine("Welke tafel wil je zien?");
            tafel = Convert.ToInt32(Console.ReadLine());
            for (teller = 1; teller <= 10; teller++)
            {                
                product = teller * tafel;
                Console.WriteLine(product);
            }

            Console.WriteLine("Wat is je naam?");
            naam = Console.ReadLine();
            Console.WriteLine("Wat is je leeftijd?");
            leeftijd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hallo " + naam);
            if (leeftijd > 22)
            {
                Console.WriteLine("Jij bent ouder dan 21.");
            }
            if (leeftijd < 22)
            {
                Console.WriteLine("Jij bent jonger dan 21.");
            }
            if (leeftijd == 22)
            {
                Console.WriteLine("Jij bent precies 21 jaar oud.");
            }

            Console.WriteLine("Deze regel is uitgevoerd voor een function regel.");
            p.TestFunction();

            Console.WriteLine("Deze regel is voor de for-lus uitgevoerd.");
            int c = 0;
            for (c = 0; c <= 3; c++)
            {
                Console.WriteLine("Deze regel is in de for-lus voor de function uitgevoerd.");
                p.TestFunction();
                Console.WriteLine("Deze regel is in de for-lus na de function uitgevoerd.");
            }

            int dagen = 0;
            for (dagen = 0; dagen < 7; dagen++)
            {
                Console.WriteLine(weekdagen[dagen]);
            }

            Console.ReadKey();
            
        }
        
    } 
}
