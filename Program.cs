using System;
using System.Linq;

namespace _2.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];
            for (int i = 0; i < rotation; i++)
            {
                RotateArray(numbers);
                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] += numbers[j];
                }
            }
            Console.WriteLine(string.Join(" ",sum));
        }

        static void RotateArray(int[] numbers)
        {
            var lastNumber = numbers.Last();
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
            }
            numbers[0] = lastNumber;
        }
    }
}