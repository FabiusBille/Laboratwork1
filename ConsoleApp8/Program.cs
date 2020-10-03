using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, string, char, string, ulong) cort = (12, "cat", '+', "dog", 22433254);
            Console.WriteLine($"{cort}");
            Console.WriteLine($"{cort.Item1}\t{cort.Item3}\t{cort.Item4}\t");
            (int a, string b, char c, string d, ulong e) cort1;
            cort1 = cort;
            Console.WriteLine($"{cort1.a}\t{cort1.c}\t{cort1.d}\t");
            var (q, w, e, r, t) = cort1;
            Console.WriteLine($"{q}\t{e}\t{w}\t");
            int ty = 0;
            ty = cort.Item1;
            Console.WriteLine($"{ty}");
            Console.WriteLine(cort==cort1);
        }
    }
}
