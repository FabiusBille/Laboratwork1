using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        
        private const char Separator = ',';

        static void Main(string[] args)
        {
            string str1 = "I am Nick!";
            Console.WriteLine(string.Compare(str1, "I am NAick"));
            if (string.Compare(str1, "I am Nick") == 0)
            { Console.WriteLine("the same"); }


            if (string.Compare(str1, "I am Nick") < 0)
            { Console.WriteLine("second is first"); }


            if (string.Compare(str1, "I am Nick") > 0)
            { Console.WriteLine("first is first"); }

            string str2 = "Hi, ";
            string str3 = ",have we already met?";
            str2 += str1;
            Console.WriteLine($"str2+str1={str2}");
            str1 = str2;
            Console.WriteLine($"str2+str1={str1}");
            string[] words = str1.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine($"str2={str2.Length}");
           
            int n1 = 8;
         
            int n2 = 5;

       str2 = str2.Substring(0, str2.Length - n2);
            Console.WriteLine($"str5={str2}");
            Console.Write("Enter number from which we should delete in str2=");
            int n3 = Console.Read();
            str2= str2.Substring(0, str2.Length - n2);
            str2 += str3;
            Console.WriteLine($"str2={str2}");
            string ste = "";
          
            string ste2 = null;
          
            Console.WriteLine($"ste={ste}");
            Console.WriteLine($"ste2={ste2}");
            if(string.IsNullOrEmpty(str1))
                Console.WriteLine($"ste={ste} is empty");
            StringBuilder what = new StringBuilder(20);
            what = what.Insert(0, "rHat happend");

            what = what.Remove(0, 1);
            what = what.Insert(0, 'W');
            what = what.Replace('H', 'h');
            what = what.Append('!');
            Console.WriteLine($"what={what}");
            

        }
    }
}
