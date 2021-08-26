using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace _0826_CSharp
{
    class Program
    {

        #region 4교시
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


        // interface ILogger
        // {
        //     void Log(string s);
        //     void Log(string s, int p);
        // }

        // class MyLogger : ILogger
        // {
        //     public void Log(string s)
        //     {
        //         System.Console.WriteLine(s);
        //     }
        //     public void Log(string s, int p)
        //     {
        //         System.Console.WriteLine($"{s}\r\nParam: {p}");
        //     }
        // }


        //     static void Main(string[] args)
        //     {
        //         #region 
        //         // ClassA classA = new ClassA(); classA.Method("wasans");
        //         // // CBasic cBasic = new CBasic(); // <= 오류가 나게 됨
        //         // // IBasic iBasic = new IBasic(); // <= 오류가 나게 됨

        //         // CBasicChild child = new CBasicChild();
        //         // child.Method("wasans");
        //         // CBasicInterface child2 = new CBasicInterface();
        //         // child2.Method("waaa");
        //         #endregion

        //         MyLogger logger = new MyLogger();
        //         logger.Log("와센즈");

        //         System.Console.WriteLine();

        //         logger.Log("와센즈", 154);

        //     }
        // }

        #endregion

        #region 5교시

        // class Product : IComparable
        // {
        //     public string Name  { get; set; }
        //     public int Price { get; set; }
        //
        //     public int CompareTo(object obj)
        //     {
        //         // = 0 : 같음
        //         // > 0 : 큼
        //         // < 0 : 작음
        //         // return Price - (obj as Product).Price;
        //         //return -Price + (obj as Product).Price;
        //      
        //         //return Price.CompareTo((obj as Product).Price);
        //         return Name.CompareTo((obj as Product).Name);
        //     }
        //
        //     public override string ToString()
        //     {
        //         return Name + " : " + Price + "원";
        //     }
        // }

        // class Dummy : IDisposable
        // {
        //     public void Dispose() // 리소스 해제함 (GC)
        //     {
        //         System.Console.WriteLine("Dispose");
        //     }
        // }

        // interface IBasic
        // {
        //     void Method();
        //     //int Property { get { return Property; } set { Property = value; } } // <+ dotnet 버전 따라 다른 듯 함
        //     int Property { get; set; }

        //     int this[int a] { get; set; }
        // }

        // class CBasic : IBasic
        // {
        //     public int this[int a] { get { return Property; } set { Property = value; } }

        //     public int Property { get; set; }

        //     public void Method()
        //     {
        //         System.Console.WriteLine("Hello world");
        //     }
        // }

        // static void Main()
        // {
        // List<Product> list = new List<Product>()
        // {
        //     new Product() { Name = "고구마", Price = 1500},
        //     new Product() { Name = "사과", Price = 2400},
        //     new Product() { Name = "호박고구마", Price = 2000},
        //     new Product() { Name = "바나나", Price = 1000},
        //     new Product() { Name = "배", Price = 4000}
        // };

        // list.Sort();
        // foreach(var item in list)
        // {
        //     Console.WriteLine(item);
        // }

        // Dummy dummyA = new Dummy();
        // dummyA.Dispose();

        // using(Dummy dummyB = new Dummy())
        // {
        //
        // }

        // CBasic basic = new CBasic();
        // basic.Method();
        // basic.Property = 10;
        // System.Console.WriteLine(basic.Property);

        // IBasic iBasic = new CBasic(); // IDamageable = Getcomponent<IDamageable>(); 과 같음
        // iBasic.Method();

        //}


        #endregion

        #region 6교시

        // interface IFly
        // {

        // }

        // class Car
        // {

        // }

        // class FlyCar : Car, IFly
        // {

        // }

        // class Parent
        // {

        // }
        // class Child : Parent, IDisposable, IComparable
        // {
        //     public int CompareTo(object obj)
        //     {
        //         return 0;
        //     }

        //     public void Dispose()
        //     {
        //     }
        // }

        // interface ILog
        // {
        //     void Log(string s);
        // }

        // interface IMyLog : ILog
        // {
        //     void Log(string s, int p);
        // }

        // class CLog : IMyLog
        // {
        //     public void Log(string s, int p)
        //     {

        //     }

        //     public void Log(string s)
        //     {

        //     }
        // }

        // static void Main()
        // {
        //     // Child child = new Child();
        //     // Parent parent = new Child();
        //     // IDisposable disp = new Child(); disp.Dispose();
        //     // IComparable comp = new Child(); comp.CompareTo(null);
        //     // Child child2 = (Child)disp;
        //     // Child child3 = (Child)parent;

        //     File.WriteAllText("/home/han/text.txt", "이거슨 C#으로 만들어진 파일이다아아아.");
        //     using(StreamWriter writer = new StreamWriter("/home/han/text.txt"))
        //     {
        //         writer.WriteLine("우분투쵝오");
        //         writer.WriteLine("와 센즈 아시는구나");
        //     }

        //     using(StreamReader reader = new StreamReader("/home/han/text.txt"))
        //     {
        //         string line;
        //         while((line = reader.ReadLine()) != null)
        //         {
        //             System.Console.WriteLine(line);
        //         }
        //     }

        // }

        #endregion

        #region 문제

        /*
        1
            1: O
            2: X
            3: X
            4: O
            5: X
            6: O
        2
            3
            인터페이스도 다형성을 사용할 수 있음.
        3
            1
        4
            1
        5
            는 윈폼
        */

        // static void Main()
        // {
        //     string path = "/home/han/text.txt";

        //     using(StreamReader reader = new StreamReader(path))
        //     {
        //         string data = reader.ReadToEnd();

        //         System.Console.WriteLine(data == "" ? "파일에 아무 내용도 없습니다." : $"이전에 입력한 내용: {data}");
        //     }

        //     using(StreamWriter writer = new StreamWriter(path))
        //     {
        //         System.Console.WriteLine("> 저장할 문자열을 입력해주세요: ");
        //         File.AppendAllText(path, Console.ReadLine()); // TODO string.join
        //         System.Console.WriteLine("저장했습니다.");
        //     }

        // }

        #endregion

        #region 6.2교시

        class Member
        {
            public string name1;
            public string name2;

            public Member(string name1, string name2)
            {
                this.name1 = name1;
                this.name2 = name2;
            }

            public override string ToString()
            {
                return $"{name1} {name2}";
            }
        }

        class AddrComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                return (x as Member).name1.CompareTo((y as Member).name1);
            }
        }

        static void Main()
        {
            Member[] members = new Member[3];
            members[0] = new Member("홍길동", "율도국");
            members[1] = new Member("레식샌", "김예리");
            members[2] = new Member("한우앱", "우앱");

            Array.Sort(members, new AddrComparer());

            foreach(var item in members)
            {
                System.Console.WriteLine(item);
            }
        }

        #endregion

    }
}
