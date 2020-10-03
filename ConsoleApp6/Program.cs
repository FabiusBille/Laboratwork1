using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter num of letters in mass:\t");
            int n = int.Parse(Console.ReadLine());
          
            string[] array = new string[n];
           
            for (int i=0;i<n;i++)
            { Console.WriteLine("Write:");
                array[i] = Console.ReadLine();
            }
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]}");
            }
            Console.Write("\nWhat wold you like to do:\tchange a word to another in sentance=1\tchange to entering word=2");
            int chan = int.Parse(Console.ReadLine());
            if (chan == 2)
            {
                Console.Write("\nEnter num of word to change in mass:\t");
                int ch = int.Parse(Console.ReadLine());
                array[ch] = Console.ReadLine();
            }
            else
            {
                Console.Write("\nEnter num of word to change in mass:\t");
                int fir = int.Parse(Console.ReadLine());
                Console.Write("\nEnter num of  another word to change in mass:\t");
                int sec = int.Parse(Console.ReadLine());
                if (sec >= n) { sec = n - 1; }
                if (fir >= n) { fir = n - 1; }
                string str;
                str = array[sec];
                array[sec] = array[fir];
                array[fir] = str;
            }
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]}");
            }
            Console.WriteLine($"{array.Length}");
            var abc =  new[] { 1, 2, 3, 4, 5, 6 } ;
            for (int i = 0; i < abc.Length; i++)
            {
                Console.Write($"{abc[i]}");
            }
            var abcd = new[] { "I am Nikita. ","Am i Cool Coder? " };
            for (int i = 0; i < abcd.Length; i++)
            {
                Console.Write($"{abcd[i]}");
            }
        }
    }
    
}

