using System;

namespace MethodHiding
{
    class Employee
    {
        public string firstName;
        public string lastName;

        public void PrintFullName()
        {
            Console.WriteLine(firstName+" "+lastName);
        }
    }

    class PartTimeEmployee:Employee
    {
        public new void  PrintFullName()
        {
            base.PrintFullName();
            //Console.WriteLine(firstName+" "+lastName+" "+"PTE");
        }
    }

    class FullTimeEmployee:Employee
    {
        public new void  PrintFullName()
        {
            Console.WriteLine(firstName+" "+lastName+" "+"FTE");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee pte=new PartTimeEmployee();
            pte.firstName = "Rakib";
            pte.lastName = "Ahasan";
            pte.PrintFullName();
            Console.ReadLine();
        }
    }
}
