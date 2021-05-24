using System;

namespace InterfaceInharitance
{
    interface I1
    {
        void Print();
    }
    interface I2
    {
        void Print1();
    }
    interface I3:I1,I2
    {
        void Print2();
    }
    class Program:I3
    {
        public void Print()
        {
            Console.WriteLine("This is a method from interface1 !!");
        }
        public void Print1()
        {
            Console.WriteLine("This is a method from interface2 !!");
        }
        public void Print2()
        {
            Console.WriteLine("This is a method from interface3 !!");
        }
        static void Main(string[] args)
        {
            I3 myInterface = new Program();
            myInterface.Print();
        }
    }
}
