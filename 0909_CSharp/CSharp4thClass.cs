using System;

namespace CSharp4thClass
{
    class Program
    {
        // static private int Func(int a)
        // {
        //     return a;
        // }

        // public delegate int MyDelegate(int a); // 대리자 정의

        // class MyData
        // {
        //     public int a;
        //     public int b;

        //     public int Function(int a)
        //     {
        //         return a;
        //     }
        // }

        static public int StringLength(string str)
        {
            return str.Length;
        }

        static public void Func2(MyDelegate d)
        {
            System.Console.WriteLine(d?.Invoke("와센즈"));
        }

        public delegate int MyDelegate(string str);
        

        static void Main1(string[] args)
        {
            // int a = 0; // (형식) (이름) = (값)
            // System.Console.WriteLine(a);

            // MyData data = new(); // 채신-문법

            // MyDelegate del = a => a;

            // MyDelegate del = StringLength;
            
            // Func<string, int> MyAction;
            // MyAction = StringLength;
            
            // System.Console.WriteLine(del("wa sans asinunguna"));
            // System.Console.WriteLine(MyAction("wa sans asinunguna"));

            Action<MyDelegate> myAction = Func2;
            myAction(StringLength);
            
        }
    }
}
