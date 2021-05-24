using System;

namespace ClassesAndObjects
{
    class Student
    {
        int rollno;
        string name;
        int age;
        int standard;

        //75VUN7E2JV 
        public void setRollNo(int rollno)
        {
            this.rollno = rollno;
        }
        public int getRollNo()
        {
            return this.rollno;
        }
        static void Main(string[] args)
        {
            Student ali = new Student();
            ali.setRollNo(22);
            ali.getRollNo();
            Console.WriteLine();
            
        }
    }
}
