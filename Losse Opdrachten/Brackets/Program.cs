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

            //takes the user input and checks to see if there are any other characters in it beside brackets. Afterwards it checks to see if brackets are balanced.
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

        /// <summary>
        /// Checks to see if brackets are a matching pair in the stack in BracketBalance func
        /// </summary>
        /// <param name="charOne"> First bracket put into the stack </param>
        /// <param name="charTwo"> Second bracket put into the stack </param>
        /// <returns> Boolean to BracketBalance func </returns>
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

        /// <summary>
        /// Checks if there are any other characters than brackets in users input
        /// </summary>
        /// <param name="userInput"> array of chars from users input </param>
        /// <returns> Boolean to main if else statement </returns>
        static bool HasLetters(char[] userInput)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*-_=+:;<>,.?/".ToCharArray();
            bool hasLetter = true;

            string userString = userInput.ToString();
            userString = userString.ToUpper();
            userInput = userString.ToCharArray();

            for (int i = 0; i < userInput.Length; i++)
            {
                for (int j = 0; j < alpha.Length; j++)
                {
                    if (userInput[i] == alpha[j])
                    {
                        hasLetter = true;
                        break;
                    }
                    else
                        hasLetter = false;
                }                
            }
            return hasLetter;
        }

        /// <summary>
        /// Checks to see wether brackets in users input are balanced against eachother using Stack datatype
        /// </summary>
        /// <param name="userInput"> array of chars from users input </param>
        /// <returns> Boolean for main if else statement </returns>
        static bool BracketBalance(char[] userInput)
        {
            //empty stack for storing characters
            Stack<char> str = new Stack<char>();

            //iterates over userinput and matches brackets using MatchingPair()
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
