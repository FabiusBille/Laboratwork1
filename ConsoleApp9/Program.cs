using Microsoft.VisualBasic;
using System;
using System.Linq.Expressions;
using System.IO;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int[] mas = new int[] { 1, 2, 3, 4 };
            string str = "This is string";
         (int,int,int,char) retur = GetInfo(mas, str);
            Console.WriteLine($"{retur}");
        }
        public static (int,int,int,char) GetInfo(int[] array, string strarr)
        {
            (int, int, int, char) usable;
            usable.Item1 = array.Min();
            usable.Item2 = array.Max();
            usable.Item3 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                usable.Item3 += array[i];
            }
            usable.Item4 = strarr[0];
            return usable;
        }
    }
}
