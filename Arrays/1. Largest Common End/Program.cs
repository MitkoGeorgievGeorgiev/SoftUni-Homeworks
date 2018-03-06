using System;
using System.Linq;

namespace _1.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] firstRow= Console.ReadLine().Split(' ');
           string[] secondRow = Console.ReadLine().Split(' ');
            int counter = 0;
            int lenght = Math.Min(firstRow.Length, secondRow.Length);
            for (int i = 0; i <lenght; i++)
            {
                if (firstRow[i]==secondRow[i])
                {
                    counter++;
                }
                else if (firstRow[i] != secondRow[i])
                {
                    break;
                }
            }
            firstRow = firstRow.Reverse().ToArray();
            secondRow = secondRow.Reverse().ToArray();
            int secondCounter = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (firstRow[i] == secondRow[i])
                {
                    secondCounter++;
                }
                else if (firstRow[i] != secondRow[i])
                {
                    break;
                }
            }


            Console.WriteLine(Math.Max(counter,secondCounter));

        }
    }
}