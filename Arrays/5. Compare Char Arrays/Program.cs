using System;
using System.Linq;
namespace _5.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int lenght = Math.Min(firstArray.Length, secondArray.Length);
            for (int i = 0; i < lenght; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));

                    break;
                }
                else if (secondArray[i] < firstArray[i])
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));

                    break;
                }
                if (firstArray[lenght - 1] == secondArray[lenght - 1])
                {
                    bool firstArrayIsShorter = true;
                    if (firstArray.Length > secondArray.Length)
                    {
                        Console.WriteLine(string.Join("", secondArray));
                        Console.WriteLine(string.Join("", firstArray));
                        break;


                    }
                    else if (firstArray.Length < secondArray.Length)
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        break;

                    }
                    else if (firstArray.Length == secondArray.Length)
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        break;
                    }


                }
                


            }
        }
    }
}