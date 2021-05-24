using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValueAndPassByRef_RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
           // PassByValue(value); //15

           //PassByRef(ref value);//15
           PassByOut(out value);//10
            Console.WriteLine(value);//10
            Console.ReadKey();
        }

        //public static void PassByValue(int a)
        //{
        //    a = a + 10;
        //    Console.WriteLine(a);
        //}
        public static void PassByRef(ref  int a)
        {
            a = a + 10;
            Console.WriteLine(a);
        }
        public static void PassByOut(out int a)
        {
            a = 10;
            Console.WriteLine(a);
        }
    }
}
