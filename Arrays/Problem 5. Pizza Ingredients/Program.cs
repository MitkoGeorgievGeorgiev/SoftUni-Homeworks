using System;
using System.Linq;

namespace Problem_5.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ').ToArray();
            int lenght = int.Parse(Console.ReadLine());

            int index = 0;
            string[] usedIngredients = new string[9];

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == lenght)
                {
                    if (index > 9)
                    {
                        break;
                    }

                    usedIngredients[index] = ingredients[i];

                    Console.WriteLine($"Adding {usedIngredients[index]}.");
                    index++;

                }
            }
            Console.WriteLine($"Made pizza with total of {index} ingredients.");
            Console.Write("The ingredients are: ");
            for (int i = 0; i < index; i++)
            {
                Console.Write($"{usedIngredients[i]}");
                
                if (i != index - 1)
                {
                    Console.Write(", ");
                }
                if (i==index-1)
                {
                    Console.Write(".");
                }
            }

        }
    }
}