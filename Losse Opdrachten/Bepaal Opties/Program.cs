using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bepaal_Opties
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<ShoppingList> permutations = new List<ShoppingList>();
            SumUp(new ShoppingList(), 70, permutations);

            foreach(var permutation in permutations)
            {
                Console.WriteLine(permutation);
            }

            Console.ReadKey();
        }


        private static void SumUp(ShoppingList list, int budget, List<ShoppingList> finishedList)
        {
            if (budget - list.Cost < 5)
            {
                finishedList.Add(list);
                return;
            }

            if (list.Cost + 5 <= budget)
            {
                list.numWorst++;
                SumUp(list, budget, finishedList);
                list.numWorst--;
            }

            if (list.Cost + 10 <= budget)
            {
                list.numBurgers++;
                SumUp(list, budget, finishedList);
                list.numBurgers--;
            }

            if (list.Cost + 15 <= budget)
            {
                list.numFrikandel++;
                SumUp(list, budget, finishedList);
                list.numFrikandel--;
            }
        }

        private struct ShoppingList
        {
            public int numBurgers;
            public int numFrikandel;
            public int numWorst;
            public int Cost => numBurgers * 10 + numFrikandel * 15 + numWorst * 5;
            public override string ToString()
            {
                return $"Burgers: {(numBurgers + 1) * 20}, Frikandellen: {(numFrikandel + 1) * 25}, Worsten: {(numWorst + 1) * 6}";
            }
        }
    }
}
