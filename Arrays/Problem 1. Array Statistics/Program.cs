using System;
using System.Linq;

namespace Problem_1.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            double average = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>max)
                {
                    max = numbers[i];
                }
                if (numbers[i]<min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            average = sum / (double)numbers.Length;
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");

        }
    }
}