using System;
using System.Collections.Generic;

namespace _0826_CSharp
{
    class Program
    {

        #region 
        // class ClassA
        // {
        //     public void Method(string message)
        //     {

        //     }
        // }

        // abstract class CBasic
        // {
        //     abstract public void Method(string message);
        //     public int num = 0;
        // }

        // class CBasicChild : CBasic
        // {
        //     public override void Method(string message)
        //     {
        //         System.Console.WriteLine(message);
        //     }
        // }

        // interface IBasic
        // {
        //     void Method(string message);
        //     //int num { get; set; }
        // }

        // class CBasicInterface : IBasic
        // {
        //     public void Method(string message)
        //     {
        //         System.Console.WriteLine("와 센즈 아시는구나");
        //     }
        // }
        #endregion

        interface ILogger
        {
            void Log(string s);
            void Log(string s, int p);
        }

        class MyLogger : ILogger
        {
            public void Log(string s)
            {
                System.Console.WriteLine(s);
            }
            public void Log(string s, int p)
            {
                System.Console.WriteLine($"{s}\r\nParam: {p}");
            }
        }


        static void Main(string[] args)
        {
            #region 
            // ClassA classA = new ClassA(); classA.Method("wasans");
            // // CBasic cBasic = new CBasic(); // <= 오류가 나게 됨
            // // IBasic iBasic = new IBasic(); // <= 오류가 나게 됨

            // CBasicChild child = new CBasicChild();
            // child.Method("wasans");
            // CBasicInterface child2 = new CBasicInterface();
            // child2.Method("waaa");
            #endregion

            MyLogger logger = new MyLogger();
            logger.Log("와센즈");

            System.Console.WriteLine();

            logger.Log("와센즈", 154);

        }
    }
}
