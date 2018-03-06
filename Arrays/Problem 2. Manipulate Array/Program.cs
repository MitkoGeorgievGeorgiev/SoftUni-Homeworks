using System;
using System.Linq;

namespace Problem_2.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "END")
                {
                    
                    break;
                }

                else if (command[0] == "Reverse")
                {
                    array = array.Reverse().ToArray();

                }
                else if (command[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    if (index > array.Length - 1||index<0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        array[index] = command[2];
                    }


                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            Console.WriteLine(string.Join(", ", array));










        }
        

       
    }
}