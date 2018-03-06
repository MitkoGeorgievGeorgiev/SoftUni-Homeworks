using System;
using System.Linq;

namespace _8.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrays = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = 0;
            int count = 0;
            
            for (int i = 0; i < arrays.Length; i++)
            {
                int SecondCounter = 0;
                for (int j = 0; j < arrays.Length; j++)
                {
                
                    if (arrays[j]==arrays[i])
                    {
                        SecondCounter++;
                        
                        if (SecondCounter>count)
                        {
                            count = SecondCounter;
                            number = arrays[i];
                        }
                    }
                }
                
            }
            Console.WriteLine(number);
        }
    }
}