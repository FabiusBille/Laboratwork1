using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[3, 4] { { 0, 1, 2, 7 }, { 3, 4, 5, 9 }, { 6, 3, 2, 7 } } ;
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            string[] mas2 = new string[3] { "hi ", "i am", "cool" };
            Console.WriteLine(mas2.Length);
            Console.WriteLine();
            for (int i = 0; i < mas2.Length; i++)
                Console.Write(mas2[i]);
            Console.WriteLine();
            int n = 1;string str = "one";
            mas2[n] =str;

            for (int i = 0; i < mas2.Length; i++)
                Console.Write(mas2[i]);



        }
    }
}
