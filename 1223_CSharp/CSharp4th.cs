using System;
using System.Threading;

namespace _1223Csharp
{
    public class Program
    {
        // static public void ThreadProc()
        // {
        //     for (int i = 0; i < 5; ++i)
        //     {
        //         System.Console.WriteLine("working... {0}", i);
        //         Thread.Sleep(100);
        //     }
        // }

        // static public void ParameterizedThreadProc(object radius) 
        // {
        //     double area = Math.Pow((double)radius, 2) * Math.PI;
        //     System.Console.WriteLine(area);
        // }

        class Counter
        {
            const int LOOP_COUNT = 100000;
            private int count;
            readonly object crit;

            public int Count
            {
                get { return count; }
            }

            public Counter()
            {
                count = 0;
                crit = new object();
            }

            public void Increment()
            {
                int loopcount = LOOP_COUNT;

                while(--loopcount >= 0)
                {
                    lock(crit)
                    {
                        ++count;
                    }
                }
            }

            public void Decrement()
            {
                int loopcount = LOOP_COUNT;

                while (--loopcount >= 0)
                {
                    // lock(crit)
                    // {
                    //     --count;
                    // }

                    Monitor.Enter(crit);
                    --count;
                    Monitor.Exit(crit);
                }
            }
        }

        static void _Main(string[] args)
        {
            Counter obj = new();
            Thread t1 = new(obj.Increment);
            Thread t2 = new(obj.Decrement);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            System.Console.WriteLine(obj.Count);

            // System.Console.WriteLine("{0, -16} : {1}", ThreadState.Aborted, (int)ThreadState.Aborted);
            // System.Console.WriteLine("{0, -16} : {1}", ThreadState.Background | ThreadState.StopRequested, (int)ThreadState.Background | (int)ThreadState.StopRequested);


            // Thread t3 = new Thread(() => { System.Console.WriteLine("wa sans");});
            // t3.IsBackground = true;
            // t3.Start();
            // t3.Join();

            // Thread t2 = new Thread(ParameterizedThreadProc);
            // t2.Start(20.0);

            // Thread t1 = new Thread(ThreadProc);
            // t1.Start();
            // for (int i = 0; i < 5; ++i)
            // {
            //     System.Console.WriteLine("working again... {0}", i);
            //     Thread.Sleep(100);
            // }
            // // t1.Abort(); // <= 리눅스 지원 안함
            // // t1.Interrupt();
            // t1.Join();
            // System.Console.WriteLine("work is done!");
        }
    }
}