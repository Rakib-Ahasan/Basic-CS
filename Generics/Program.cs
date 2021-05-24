using System;
using System.Security.Cryptography.X509Certificates;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
           //Example<string> example=new Example<string>();
           //example.enter = "Rakib Ahasan";

           //Example<int> example1=new Example<int>();
           //example1.enter = 001;
           //Console.WriteLine(example.enter);
           //Console.WriteLine(example1.enter);

           //Console.ReadLine();
           //Example<int> example=new Example<int>(001);

           //Example<string> example1=new Example<string>("Rakib");

           ////example1.GetEnter("Rakib");
           // //example.GetEnter(001);
           
           
           //Console.WriteLine(example.GetEnter());
           //Console.WriteLine(example1.GetEnter());
           Example<int>example=new Example<int>();
           example.e = 001;
           Console.WriteLine(example.e);
           Example<string>example1=new Example<string>();
           example1.e = "Sagor";
           Console.WriteLine(example1.e);
        }
    }
}
