using System;
using System.Collections.Generic;
using System.Linq;


namespace CSharp4th
{
    class Program
    {
        // static int Method()
        // {
        //     return 10;
        // }

        // delegate int MyDelegate();

        // static void Main(string[] args)
        // {
        //     MyDelegate del = Method;

        //     Func<int> func = () => 10;

        //     System.Console.WriteLine($"func() : {func()}"); 
        // }

        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // List<int> output = new List<int>();

            // foreach (var item in input)
            // {
            //     if (item % 2 == 0)
            //     {
            //         output.Add(item);
            //     }
            // }
            // foreach(int item in output)
            // {
            //     System.Console.Write(item + " ");
            // }
            // System.Console.WriteLine();

            // var output = from item in input
            //              where (item & 1) != 1
            //              select item;
            // output.ToList().ForEach(e => System.Console.WriteLine(e));

            // (from item in input select item * 2).ToList().ForEach(e => System.Console.Write(e + " "));
            // (from item in input select item * item).ToList().ForEach(e => System.Console.Write(e + " "));
            //(from item in input where item > 4 select item * 2).ToList().ForEach(e => System.Console.Write(e + " "));
            (from item in input where item > 5 && (item & 1) != 1 select item).ToList().ForEach(e => System.Console.Write(e + " "));

            System.Console.WriteLine();

        }
    }
}
