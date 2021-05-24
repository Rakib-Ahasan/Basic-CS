using System;
using System.Collections;
using Collection;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList= new ArrayList();
            myList.Add(10);
            myList.Add("Rakib");
            Console.WriteLine(myList.Capacity);
            foreach (object obj in myList)
            {
                Console.WriteLine(obj);
            }
            myList.Remove(10);
            foreach (object obj in myList)
            {
                Console.WriteLine(obj);
            }


            //Person[] peopleArray = new Person[3]
            //{
            //    new Person("John", "Smith"),
            //    new Person("Jim", "Johnson"),
            //    new Person("Sue", "Rabon"),
            //};

            //People peopleList = new People(peopleArray);
            //foreach (Person p in peopleList)
            //    Console.WriteLine(p.firstName + " " + p.lastName);
        }
    }
}
