using System;
using System.Linq;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isTrue = false;
            for (int i = 0; i < numbbersArr.Length; i++)
            {
                int[] first = numbbersArr.Take(i).ToArray();
                int[] second = numbbersArr.Skip(i+1).ToArray();
                if (first.Sum()==second.Sum())
                {
                    Console.WriteLine(i);
                    isTrue = true;
                    break;

                }

            }
            if (isTrue==false)
            {
                Console.WriteLine("no");
            }
        }
    }
}