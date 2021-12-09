using System;
using System.Runtime.CompilerServices;

namespace CSharp_1209
{
    /*
    // class MyClass
    // {
    //     [Obsolete("use NewMethod() instead.")]
    //     public void OldMethod()
    //     {
    //         System.Console.WriteLine("I'm old");
    //     }
    //     public void NewMethod()
    //     {
    //         System.Console.WriteLine("I'm new");
    //     }
    // }

    // public static class Trace
    // {
    //     public static void WriteLine(string message,
    //         [CallerFilePath]   string file = "", // 호출한 파일 경로
    //         [CallerLineNumber] int line = 0, // 호출된 라인
    //         [CallerMemberName] string member = "") // 이 함수를 호출한 멤버
    //     {
    //         System.Console.WriteLine($"{file}(Line:{line}) {member}: {message}");
    //     }
    // }
    */

    
    [System.AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class History : Attribute
    {
        private string programmer;
        public string Programmer { get { return programmer; } }
        public double Version { get; set; }
        public string Changes { get; set; }

        public History(string programmer)
        {
            this.programmer = programmer;
            Version = 1.0;
            Changes = "First release";
        }
    }

    [History("Han", Version = 0.1, Changes = "wa sans added")]
    [History("Han", Version = 0.2, Changes = "wa sans removed")]
    class MyClass
    {
        public void Function()
        {
            System.Console.WriteLine("Function()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            System.Console.WriteLine("MyClass change history...");

            foreach(Attribute a in attributes)
            {
                History h = a as History;

                if(h != null)
                {
                    System.Console.WriteLine("Ver:{0}, Programmer:{1}, Changes:{2}", h.Version, h.Programmer, h.Changes);
                }
            }


            // MyClass obj = new MyClass();
            // obj.Function();

            // Trace.WriteLine("WaSans");

            // MyClass obj = new();
            // obj.OldMethod();
        }
    }
}