using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharp4th
{
    class Program
    {
        // delegate double Compare<T>(T a, T b);
        // //delegate float Compare(float a, float b);

        // // static int AscendComapre(int a, int b)
        // // {
        // //     return a - b;
        // // }

        // // static int DescendCompare(int a, int b)
        // // {
        // //     return b - a;
        // // }

        // static void BubbleSort<T>(T[] dataSet, Compare<T> comparer)
        // {
        //     int i = 0;
        //     int j = 0;
        //     T temp;

        //     for (i = 0; i < dataSet.Length; ++i)
        //     {
        //         for (j = 0; j < dataSet.Length - (i + 1); ++j)
        //         {
        //             if (comparer(dataSet[j], dataSet[j + 1]) > 0)
        //             {
        //                 temp = dataSet[j + 1];
        //                 dataSet[j + 1] = dataSet[j];
        //                 dataSet[j] = temp;
        //             }
        //         }
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     int[] array = { 3, 6, 1, 7, 8, 2, 5, 10 };
        //     float[] fArray = { 3.1f, 6.02f, 5.02f, 5.3f, 3.2f, 4.1f, 5.1f, 3.4f };

        //     BubbleSort(array, (x, y) => x - y); // ascend
        //     //BubbleSort(array, (x, y) => y - x); // desend

        //     array.ToList().ForEach(x => {
        //         System.Console.WriteLine(x);
        //     });

        //     System.Console.WriteLine();

        //     BubbleSort(fArray, (x, y) => x - y);

        //     fArray.ToList().ForEach(x => {
        //         System.Console.WriteLine(x);
        //     });

        // }

        delegate void EventHandler(string msg);

        class MyNotifier
        {
            public event EventHandler SomethingHappened;
            public void DoSomething(int number)
            {
                int temp = number % 10;
                if (temp != 0 && temp % 3 == 0)
                {
                    SomethingHappened(String.Format("{0} : 짝", number));
                }
                else
                {
                    SomethingHappened(String.Format("{0}", number));
                }
            }
        }

        static void Main2(string[] args)
        {
            MyNotifier myNotifier = new();
            myNotifier.SomethingHappened += (msg) => System.Console.WriteLine(msg);
            for (int i = 0; i < 20; ++i)
            {
                myNotifier.DoSomething(i);
            }
        }
    }
}
