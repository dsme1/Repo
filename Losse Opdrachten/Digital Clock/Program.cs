using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Digital_Clock
{
    class Program
    {
        static void Main(string[] args)

        {
            Program PC = new Program();
            ThreadStart TS = new ThreadStart(PC.ShowTime);
            Thread t = new Thread(TS);
            t.Start();
            Console.ReadLine();
        }

        /// <summary>
        /// Calculates current time and keeps rewriting the string indefinitely with a thread timer set to 1 second.
        /// </summary>
        public void ShowTime()
        {
            for (; ; )
            {
                Console.WriteLine(DateTime.Now.ToString());
                Console.WriteLine("\a");
                Thread.Sleep(1000);
                Console.Clear();
            }

        }
    }
}
