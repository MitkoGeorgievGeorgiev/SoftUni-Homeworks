using System;
using System.Linq;

namespace Problem_6.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int priceGold = price[1];
            int priceJewels = price[0];
            int jewels = 0;
            int gold = 0;
            int sumOfExpanses = 0;
            while (true)
            {
            string[] lootAndExpenses = Console.ReadLine().Split(' ').ToArray();
                string loot = lootAndExpenses[0];
                int expenses = int.Parse(lootAndExpenses[1]);
                sumOfExpanses += expenses;
                if (lootAndExpenses[0]=="Jail")
                {
                    break;
                }
                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        jewels++;
                    }
                    else if (loot[i] =='$')
                    {
                        gold++;
                    }

                }

            }
            int totalEarnings = (jewels * priceJewels + gold * priceGold);
            if (totalEarnings>sumOfExpanses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings-sumOfExpanses}.");
            }
            else if (totalEarnings < sumOfExpanses)
            {
                Console.WriteLine($"Have to find another job. Lost: {sumOfExpanses-totalEarnings}.");
            }
        }
    }
}