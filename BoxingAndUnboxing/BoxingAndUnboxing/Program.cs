using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;//value type
            object obj1 = num1;//implicit conversion this process called boxing.
            int num2 = (int)obj1;//explicit conversion this process called unboxing.
        }
    }
}
