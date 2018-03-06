using System;

namespace _4.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            bool[] arr = new bool[n+1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            }
            arr[0] = false;
            arr[1] = false;
            int p = 2;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                
                if (arr[i]==true)
                {
                    for (int j = i*i; j <= n; j+=i)
                    {
                        arr[j] = false;

                    }
                }
               
                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    Console.WriteLine(i+" ");
                }
            }
            

        }
    }
}