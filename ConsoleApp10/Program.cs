using Microsoft.VisualBasic;
using System;
using System.Linq.Expressions;
using System.IO;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {


        static void Main(string[] args)
        {
            
          int retur = GetInfo();
          Console.WriteLine($"{retur}");
            int retur2 = GetInfo2();
            Console.WriteLine($"{retur2}");
        }
        public static int GetInfo()
        {


            int usable = 999999999;
            checked
            {
                int a = 999999999;
                usable += a + 999999999;

                Console.WriteLine($"{usable}");
            }
            return usable;
        }
        public static int GetInfo2()
        {
           
            
                int usable2 = 999999999;
              unchecked{  int a = 999999999;
                usable2 += a + 999999999;
                
                Console.WriteLine($"{usable2}");
            }
            return usable2    ;
        }
    }
}
