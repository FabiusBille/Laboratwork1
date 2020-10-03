using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            short a = 10;
            Console.WriteLine($"a = {a} is a variable of type short(int16) - from -32768 to 32767");
            bool choise = true;
            Console.WriteLine($"choise = {choise} is a variable of type bool - it's true/false");
            byte bit = 2;
            Console.WriteLine($"bit = {bit} is a variable of type byte - from 0 to 255");
            sbyte sbyt = 98;
            Console.WriteLine($"sbyt = {sbyt} is a variable of type sbyte - from -128 to 127");
             char let = 'l';
            Console.WriteLine($"let = {let} is a variable of type char - letters + nums 0-9");
            decimal dec = 32;
            Console.WriteLine($"dec = {dec} is a variable of type decimal - 16 byte numbers with - or + and ");
            double dyb = 9.8;
            Console.WriteLine($"dyb = {dyb} is a variable of type double - number with dot");
           float flo = 3808/654;
            Console.WriteLine($"flo = {flo} is a variable of type float - smaller num with dot");
     int inf = 55;
            Console.WriteLine($"inf = {inf} is a variable of type int 32 - 4 byte");
            uint un=34;
            Console.WriteLine($"un = {un} is a variable of type int - 0 to 4294967295");
            long welo = -654735863876458;
            Console.WriteLine($"welo = {welo} is a variable of type long - signed 64 bit integer");
            ulong unlon = 567657657575675555;
            Console.WriteLine($"unlon = {unlon} is a variable of type ulong - unsigned 64 integer");
            ushort ush = 98;
            object ob = unlon;
            Console.WriteLine($"ush = {ush} is a variable of type ushort - unsigned 16 bit int");
            inf = a;
            Console.WriteLine($"inf = {inf} is a variable of type int32 with contains number, conversed from int 16");
            flo = (float)dyb;
            Console.WriteLine($"flo = {flo} is a variable of type float - with num conversed from double");
            dyb = flo;

            Console.WriteLine($"dyb = {dyb} is a variable of type double - with number from float");
            inf = (int)un;
            Console.WriteLine($"inf = {inf} is a variable of type int - with number from unsigned int");
            ush = (ushort)a;
           
            Console.WriteLine($"ush = {ush} is a variable of type ushort with num from short");
            unlon = (ulong)welo;
            
            Console.WriteLine($"unlon = {unlon} is a variable of type ulong with num of long");
            dec = (decimal)dyb;
            
            Console.WriteLine($"dec = {dec} is a variable of type decimal - with num from double");
            welo = a;
            
            Console.WriteLine($"welo = {welo} is a variable of type long with num from short");
            un = ush;
         
            Console.WriteLine($"un = {un} is a variable of type uint with num from ushort");
            unlon = un;
            Console.WriteLine($"unlon = {unlon} is a variable of type ulong with num from uint");

            unlon = (ulong)ob;
            Console.WriteLine($"unlon = {unlon} is a variable of type ulong which was boxed in ob and unboxed ");
            var nien = 90987765.7;
            Console.WriteLine($"nien = {nien} is a variable of unsigned type (i use var )");
         nien = 'h';
            Console.WriteLine($"nien = {nien} is a variable of unsigned type (i use var )");
            nien = 'b';
            Console.WriteLine($"nien = {nien} is a variable of unsigned type (i use var )");
            int? nulcouldbe;
            nulcouldbe = null;
            Console.WriteLine($"nulcouldbe = {nulcouldbe} is a variable of int type int with is abble to have null");
            //int nulcouldnbe;
            //nulcouldbe = null;
           // Console.WriteLine($"nulcouldnbe = {nulcouldnbe} is a variable of int type int");
        }
    }
}
