using System;
using System.Runtime.CompilerServices;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enater something");
            //string message = Console.ReadLine();
            //Console.WriteLine("Your have enterd this:");
            //Console.WriteLine(message);

            //string msg = Console.ReadLine();
            //Console.WriteLine(msg);

            //Console.WriteLine(Console.ReadLine());
            // Console.ReadKey();

            //string msg, ndf;
            //msg = "hfjkhfkashdf";
            //ndf = "fhfs";
            //Console.WriteLine(msg);
            //Console.WriteLine(ndf);

            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt);
            //int i = 123;
            //float j = i;
            //Console.WriteLine(j);
            //float j = 343.5f;
            //int i =(int) j;
            //Console.WriteLine(i);
            //Console.WriteLine("Enter first Number");
            //double firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter 2nd Number");
            //double secondNumber = Convert.ToDouble(Console.ReadLine());
            //double sum = firstNumber + secondNumber;
            //Console.Write("The sum is:");
            //Console.WriteLine(sum);

            //int sum = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    sum +=i;
            //    if (i == 5)
            //        break;

            //}
            //Console.WriteLine(sum);

            //int[] nums=new int[5] {12,23,34,56,37};

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i] + 10);
            //}

            //foreach (var number in nums)
            //{
            //    Console.WriteLine(number);
            //}

            var nums = new[] { 10, 15, 16, 8, 6 };
           // var names = new[] { "dam","ram","sam"};
           Array.Sort(nums);
           foreach (var number in nums)
           {
               Console.WriteLine(number);
           }



        }
    }
}
