using System;
using System.Linq;
namespace _9.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabetic = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string word = Console.ReadLine();
            
            char[] chars = word.ToArray();
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < alphabetic.Length; j++)
                {
                    if (chars[i]==alphabetic[j])
                    {
                        Console.WriteLine($"{chars[i]} -> {j}");
                    }
                }
            }


        }
    }
}