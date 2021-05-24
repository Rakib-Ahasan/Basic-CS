using System;

namespace Delegates
{
    public delegate void Calculate(int a, int b);
    class Program
    {
        public static void Addition(int a , int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is: {0}",result);
        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction result is: {0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is: {0}", result);
        }
        public static void Divirion(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Divirion result is: {0}", result);
        }
        static void Main(string[] args)
        {
            Calculate obj = new Calculate(Addition);
            obj.Invoke(20, 30);

            obj = Subtraction;
            obj(70, 50);

            obj = Multiplication;
            obj(3, 8);

            obj = Divirion;
            obj(15, 3);

            Console.ReadLine();
            //ral
            
        }
    }
}
