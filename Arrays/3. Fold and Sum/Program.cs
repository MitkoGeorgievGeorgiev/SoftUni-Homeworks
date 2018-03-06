using System;
using System.Linq;

namespace _3.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int[] arr =  Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] left = arr.Take(arr.Length / 4).ToArray();
            int[] right = arr.Skip(arr.Length * 3 / 4).ToArray();
            int[] middle = arr.Skip(k).Take(2*k).ToArray();
            int[] leftReversed = left.Reverse().ToArray();
            int[] rightReversed = right.Reverse().ToArray();
            int[] result = new int[k*2];
            for (int i = 0; i < k; i++)
            {
                middle[i] += leftReversed[i];
                middle[i + k] += rightReversed[i];
            }
            Console.WriteLine(string.Join(" ",middle));
            

        }
    }
}
