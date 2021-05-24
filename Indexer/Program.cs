using System;
using System.Collections.Concurrent;

namespace Indexer
{
    class Program
    {
        class Employee
        {
            private int[] Age = new int[3];

/*public int this[int index]
            {
                get 
                { 
                    return Age[index];
                }
                set
                {
                    Age[index] = value;
                }
            }*/

            //Indexer Overloading Example..
            public int this[int index, int i]
            {
                get 
                { 
                    return Age[index] + i;
                }

                set 
                {
                    if (index>=0 && index<Age.Length)
                    {
                        if (value>0)
                        {
                            Age[index] = value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid value!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid index!!");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[0,1] = 5;
            Console.WriteLine(emp[0,1]);
          
            StringDataStore stringDataStore= new StringDataStore();
            stringDataStore[0] = "One";
            stringDataStore[1] = "Two";
            stringDataStore[2] = "Three";
            stringDataStore[3] = "Four";
            stringDataStore[4] = "Five";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stringDataStore[i]);
            }
        }
    }
}
