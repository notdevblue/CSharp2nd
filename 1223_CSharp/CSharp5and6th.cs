using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace _1223Csharp
{
    public class Charp5th
    {
        // static void Run()
        // {
        //     System.Console.WriteLine("Long running method");
        // }

        // static void SomeMethod(long number)
        // {
        //     for (int i = 0; i < number; ++i)
        //     {
        //     }
        //     if(number == 100000 - 1) {
        //         System.Console.WriteLine(number);
        //     }
        // }

        // static int CalcSize(string data)
        // {
        //     string s = data == null ? "" : data.ToString();

        //     Thread.Sleep(3000);
        //     return s.Length;
        // }

        // static string Popup(string data)
        // {
            // Thread.Sleep(3000);
            // return (answer == "yes" || answer == "Yes") ? "예 를 눌렀습니다" : "아니오 를 눌렀습니다.";

            // string msg = data;
            // string rt = "";

            // System.Console.WriteLine(data);

            // if ((new Random()).NextSingle() >= 0.5) {
            //     rt = "yes";
            // } else {
            //     rt = "no";
            // }

            // return rt;
        // }

        // async static private void MyMethodAsync(int count)
        // {
        //     System.Console.WriteLine("MyMethod started");
        //     await Task.Run(async () => {
        //         for (int i = 1; i <= count; ++i)
        //         {
        //             await Task.Delay(1000);
        //             System.Console.WriteLine("Delay");
        //         }
        //     });
        //     System.Console.WriteLine("MyMethod ended");
        // }

        async static Task PrintAnswerToLife()
        {
            await Task.Delay(5000);
            int answer = 21 * 2;
            System.Console.WriteLine(answer);
        }

        async static Task GoAsync()
        {
            await PrintAnswerToLife();
            System.Console.WriteLine("Done");
        }


        static void Main(string[] args)
        {
            GoAsync();

            System.Console.WriteLine("Main");

            System.Console.ReadLine();

            // System.Console.WriteLine("Main started");
            // MyMethodAsync(3);
            // System.Console.WriteLine("Main ended");
            // System.Console.ReadLine();

            // Task<int> task = Task.Factory.StartNew<int>(
            //     () => CalcSize("Hello World")
            // );

            // Task<string> task2 = Task.Factory.StartNew<string>(() => {
            //     return Popup("허락 하시겠습니까?");
            // });

            // int result = task.Result;
            // System.Console.WriteLine("Result: {0}", result);

            // string result2 = task2.Result;
            // System.Console.WriteLine("{0}", result2);

            // for (int i = 0; i < 100000; ++i)
            // {
            //     SomeMethod(99999);
            // }

            // Parallel.For(0, 100000, (i) => {
            //     SomeMethod(i);
            // });

            // var myTask = Task<List<int>>.Run(() => {
            //     Thread.Sleep(1000);

            //     List<int> list = new();

            //     list.Add(1);
            //     list.Add(5);
            //     list.Add(4);
            //     list.Add(1);

            //     return list;
            // });

            // System.Console.WriteLine("Main is running...");

            // myTask.Wait();
            // myTask.Result.ForEach((e) => {
            //     System.Console.WriteLine(e);
            // });

            // Task t1 = new(() => {
            //     System.Console.WriteLine("Long running method");
            // });
            // t1.Start();
            // t1.Wait();

            // Task t2 = Task.Run(() => {
            //     System.Console.WriteLine("Another long running method");
            // });
            // t2.Wait();

            // Task.Factory.StartNew(() => {
            //     System.Console.WriteLine("Short running method");
            // });
        }
    }
}