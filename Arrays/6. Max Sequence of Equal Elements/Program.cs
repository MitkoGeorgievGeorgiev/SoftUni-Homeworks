using System;
using System.Linq;

namespace _6.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
                int len = 1;
            int bestStart = 0;
            int bestLen = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {

                    len++;
                    if (len > bestLen)
                    {
                        bestStart = start;
                        bestLen = len;
                    }

                }

                else 
                {

                    start = i;
                    
                    
                    len = 1;

                }
               
            }
            for (int i = bestStart; i < bestStart+bestLen; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
        }
    }
}