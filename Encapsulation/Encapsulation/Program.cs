using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
         string Name;
         int Age;

         public void SetName(string name)
         {
             if (string.IsNullOrEmpty(name))
             {
                 Console.WriteLine("Name is required!!");
             }
             else
             {
                this.Name = name;
             }
         }

         public void GetName()
         {

             if (string.IsNullOrEmpty(this.Name))
             {
                 
             }
             else
             {
                 Console.WriteLine("Your Name is :" + this.Name);
             }
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p=new Person();
            p.SetName("");
           p.GetName();
            Console.ReadLine();
        }
    }
}
