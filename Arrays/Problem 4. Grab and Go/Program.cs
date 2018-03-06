using System;
using System.Linq;

namespace Problem_4.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long occurance = long.Parse(Console.ReadLine());
            long sum = 0;
            bool ThereIsOccurance = false;
            for (long i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i]==occurance)
                {
                    ThereIsOccurance = true;
                    for (long j = i-1; j >= 0; j--)
                    {
                        sum += numbers[j];
                    }
                    break;
                }
            }
            if (ThereIsOccurance)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}