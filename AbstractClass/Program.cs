using System;
using System.Reflection.Metadata.Ecma335;

namespace AbstractClass
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public long PhoneNumber;

        public abstract void PrintDetails();
    }

    class Student:Person
    {
        public int RollNo;
        public int Fees;

        public override  void PrintDetails()
        {
            string name = FirstName + " " + LastName;
            Console.WriteLine("Student Name is: {0}",name);
            Console.WriteLine("Student Age is: {0}",Age);
            Console.WriteLine("Student RollNo is: {0}",RollNo);
            Console.WriteLine("Student Phone Number is: {0}",PhoneNumber);
        }
    }

    class Teacher:Person
    {
        public string Qualuficartion;
        public double Salary;
        public override void PrintDetails()
        {
            string name = FirstName + " " + LastName;
            Console.WriteLine("Teacher Name is: {0}", name);
            Console.WriteLine("Teacher Qualification is: {0}", Qualuficartion);
            Console.WriteLine("Teacher Age is: {0}", Age);
            Console.WriteLine("Teacher Salary is: {0}", Salary);
            Console.WriteLine("Teacher Phone Number is: {0}", PhoneNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student kamal=new Student();
            kamal.FirstName = "Kamal";
            kamal.LastName = "Uddin";
            kamal.RollNo = 002;
            kamal.Age = 30;
            kamal.PhoneNumber = 148935;
            kamal.Fees = 10000;
            kamal.PrintDetails();

            Teacher tr=new Teacher();
            tr.FirstName = "Jamal";
            tr.LastName = "Uddin";
            tr.Qualuficartion = "Msc";
            tr.Salary = 30000;
            tr.Age = 40;
            tr.PhoneNumber = 65327817;
            tr.PrintDetails();

        }
    }
}
