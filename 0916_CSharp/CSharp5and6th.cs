using System;
using System.Threading;

namespace CSharp5and6th
{
    class Program
    {
        class MyEventClass
        {
            //     public event EventHandler MyEvent;

            //     public void Fire()
            //     {
            //         MyEvent?.Invoke("Fire", EventArgs.Empty); // 어느 버튼
            //     }
            // }


            static void Main(string[] args)
            {
                // MyEventClass mc = new();

                // mc.MyEvent += (sender, e) =>
                // {
                //     MyEventClass mc = new();
                // };

                // mc.Fire();

                // Func<int> func1 = () => 10;
                // Func<int> func2 = () => 154;
                // System.Console.WriteLine($"func1() : {func1()}");
                // System.Console.WriteLine($"func2() : {func2()}");

                // Func<int, int> mul = (x) => x * 2;
                // Func<float, float, float> dev = (x, y) => x / y;
                // Func<int, bool> even = (x) => (x & 1) == 0;

                // System.Console.WriteLine(mul(10));
                // System.Console.WriteLine(dev(11.0f, 2.0f));
                // System.Console.WriteLine(even(1));

                // Action act1 = () => System.Console.WriteLine("Action()");
                // act1();

                // int result = 0;
                // Action<int> act2 = (x) => result = x * x;
                // act2(3);
                // System.Console.WriteLine($"result: {result}");

                // Action<double, double> act3 = (x, y) =>
                // {
                //     double pi = x / y;
                //     System.Console.WriteLine($"Action<T1, T2>({x}, {y}) : {pi}");
                // };

                // act3(22.0, 7.0);

                // Click(() => System.Console.WriteLine("와 센즈 아시는구나"));

                // int num = 0;

                // object obj = new();

                // Thread threadA = new(() =>
                // {
                //     for (int i = 0; i < 10000000; ++i)
                //     {
                //         lock(obj)
                //             ++num;
                //     }
                // });

                // Thread threadB = new(() =>
                // {
                //     for (int i = 0; i < 10000000; ++i)
                //     {
                //         lock(obj)
                //             --num;
                //     }
                // });

                // threadA.Start();
                // threadB.Start();



                // threadA.Join();
                // threadB.Join();

                // System.Console.WriteLine(num);


                // 문제
                /*
                1. delegate, 람다, 콜백 메서드
                2
                    o
                    o
                    o
                    x
                    o
                3
                    delegate(param) {}
                    (param) => {}
                4
                    3



                */
            }

            // static void Click(Action action)
            // {
            //     action();
            // }

        }
    }
}