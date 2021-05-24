using System;
using System.Dynamic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //One or single dimensional array in C#.

            //int[] intArray = {12, 22, 32, 42};
            /* int [] intArray=new int[4];
            intArray[0] = 12;
            intArray[1] = 22;
            intArray[2] = 32;
            intArray[3] = 42;
           
            

           for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }*/

            /*foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine*/


            //Multi-dimensional array in C#.
            /*int[,] intArray1=new int[3,4]
            {
                {12,33,14,55 },
                {23,55,65,77 },
                {21,42,57,47 }
            };

            for (int i = 0; i <intArray1.GetLength(0); i++)
            {
                for (int j = 0; j < intArray1.GetLength(1); j++)
                {
                    Console.Write(intArray1[i,j]+" ");
                }

                Console.WriteLine();
            }*/

            //Jagged array in C#.
            int[][] intArray2=new int[3][];
           intArray2[0] = new int[] {12, 22, 33, 44, 55, 66, 77, 88, 99};
           intArray2[1] = new int[] {13, 24, 36, 48, 57, 67, 74};
           intArray2[2] = new int[] {15,25,35};

           //for (int i = 0; i < intArray2.GetLength(0); i++)
           //{
           //    for (int j = 0; j < intArray2[i].Length; j++)
           //    {
           //        Console.Write(intArray2[i][j]+" ");
           //    }

           //    Console.WriteLine();
           //}

           foreach (int[] items in intArray2)
           {
               foreach (int i in items)
               {
                   Console.WriteLine(i+"");
               }
           }
           Console.ReadLine();
        }
    }
}
