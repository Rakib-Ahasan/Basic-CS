using System;

namespace PropertiesInCS
{
    class Student
    {
        public int Id{ get; set; }
        public string Name { get; private set; }

        //private int _stdId;
        //private string _name;
        //private string _fname;
        //private int _studentTotalMarks = 100;

        //public int StdId
        //{
        //    set
        //    {
        //        if (value<=0)
        //        {
        //            Console.WriteLine("Id can not be 0 or negative");
        //        }
        //        else
        //        {
        //            this._stdId = value;
        //        }
        //    }
        //    get { return this._stdId; }
        //}

        //public string Name
        //{
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            Console.WriteLine("Please enter your name");
        //        }
        //        else
        //        {
        //            this._name = value;
        //        }
        //    }
        //    get { return this._name; }

        //}

        //public int StudentTotalMarks
        //{
        //    get { return this._studentTotalMarks; }
        //}

        public Student(string name)
        {
            Name = name;
        }
    }
    class Program
    {
        static void Main()
        {
            //Student s=new Student();
            //s.StdId = 23;
            //s.Name = "Sagor";
            ////s.StudentTotalMarks = 130;   //it can not take any value because it's a readonly property.

            //Console.WriteLine(s.StdId);
            //Console.WriteLine(s.Name);
            //Console.WriteLine(s.StudentTotalMarks);

            Student s=new Student("Sagor");
            Console.WriteLine(s.Name);
        }
    }
}
