using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter num of strings in mass:\t");
            int n = int.Parse(Console.ReadLine());
            int[ ][ ] array = new int[n][ ];
            for (int j = 0; j < n; j++)
            {
                Console.Write("Enter num of cols in mass:\t");
                int k = int.Parse(Console.ReadLine());
                array[j] = new int[k];
                for (int i = 0; i < k; i++)
                {
                    Console.Write($"A number in mass [{j},{i}]= ");
                    array[j][i] = int.Parse(Console.ReadLine());
                    Console.Write("\n");

                }
            }
                Console.Clear();
                for (int j = 0; j < n; j++)
                {
                    for (int  i = 0; i < array[j].Length; i++)
                    {
                        Console.Write($"\t{array[j][ i]}\t");

                    }
                    Console.Write($"\n");
                }
            

        }
    }

}

