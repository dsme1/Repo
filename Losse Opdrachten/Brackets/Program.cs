using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] userInput;

            Console.WriteLine("Voer een set brackets in die in balans is. Andere tekens of brackets die niet in balans zijn zullen niet worden geaccepteerd.");
            userInput = Console.ReadLine().ToCharArray();

            if (HasLetters(userInput))
            {
                Console.WriteLine("Programma sluit af, u houdt zich niet aan de regels.");
            }else
            {
                if (BracketBalance(userInput))
                    Console.WriteLine("Ja");
                else
                    Console.WriteLine("Nee");
            }

            Console.ReadKey();

        }

        static bool MatchingPair(char charOne, char charTwo)
        {
            if (charOne == '(' && charTwo == ')')
            {
                return true;
            }
            else if (charOne == '{' && charTwo == '}')
            {
                return true;
            }
            else if (charOne == '[' && charTwo == ']')
            {
                return true;
            }
            else
                return false;
        }

        static bool HasLetters(char[] userInput)
        {
            bool hasLetter = true;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] != '{' || userInput[i] != '(' || userInput[i] != '[')
                {
                    hasLetter = true;
                    break;
                }else
                    hasLetter = false;
            }

            return hasLetter;
        }

        static bool BracketBalance(char[] userInput)
        {
            Stack<char> str = new Stack<char>();

            for (int i= 0; i < userInput.Length; i++)
            {
                if (userInput[i] == '{' || userInput[i] == '(' || userInput[i] == '[')
                    str.Push(userInput[i]);

                if (userInput[i] == '}' || userInput[i] == ')' || userInput[i] == ']')
                    if (userInput.Count() == 0)
                    {
                        return false;
                    }else if (!MatchingPair(str.Pop(), userInput[i])){
                        return false;
                    }
            }

            if (str.Count() == 0)
                return true;
            else
                return false;
        }
    }
}
