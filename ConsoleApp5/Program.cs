using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter num of colums in mass:\t");
            int n=int.Parse(Console.ReadLine());
            Console.Write("Enter num of strings in mass:\t");
            int k = int.Parse(Console.ReadLine());
            int[ , ] array = new int[n,k];
            for (int j = 0; j < k; j++)
                for (int i = 0; i < n; i++)
            {
                Console.Write($"A number in mass [{i},{j}]= ");
               array[i,j]= int.Parse(Console.ReadLine());
                Console.Write("\n");

            }
            Console.Clear();
            for (int j = 0; j < k; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"\t{array[i, j]}\t");

                }
                Console.Write($"\n");
            }
        }
    }
}
