using System;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt=DateTime.Now;
            Console.WriteLine("{0:d}",dt);
            Console.WriteLine("{0:D}",dt);
            Console.WriteLine("{0:f}",dt);
            Console.WriteLine("{0:F}",dt);
            Console.WriteLine("{0:g}",dt);
            Console.WriteLine("{0:G}",dt);
            Console.WriteLine("{0:M}",dt);
            Console.WriteLine("{0:t}",dt);
            Console.WriteLine("{0:T}",dt);
            Console.WriteLine("{0:y}",dt);
            Console.WriteLine("{0:Y}",dt);
            Console.WriteLine("{0:yyy}",dt);
            Console.WriteLine("{0:ddd}",dt);
            Console.WriteLine("{0:dddd}",dt);
            Console.WriteLine("{0:FF}",dt);
            Console.WriteLine("{0:HH}",dt);
            Console.WriteLine("{0:MM}",dt);
            Console.WriteLine("{0:mmm}",dt);
            Console.WriteLine("{0:ss}",dt);
            Console.WriteLine("{0:HH:mm:ss tt}",dt);
            Console.WriteLine("{0:hh:mm:ss tt}",dt);
            Console.WriteLine("{0:dd-MM-yyyy}",dt);
            Console.ReadLine();
        }
    }
}
