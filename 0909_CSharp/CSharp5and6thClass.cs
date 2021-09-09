using System;
using System.Collections.Generic;

namespace CSharp5and6thClass
{
    public delegate void ICanLocateUpHereDelegate();
    
    class Program
    {
#region
        // static public int Add(int num1, int num2)
        // {
        //     return num1 + num2;
        // }

        // static public int Sub(int n1, int n2)
        // {
        //     return n1 - n2;
        // }

        // static public int Calc(MyDelegate del, int n1, int n2)
        // {
        //     return del(n1, n2);
        // }

        // public delegate int MyDelegate(int a, int b);

        // static void Main(string[] args)
        // {
        //     MyDelegate myDelegate = Add;

        //     System.Console.WriteLine(myDelegate(10, 20));

        //     myDelegate = Sub;
        //     System.Console.WriteLine(myDelegate(20, 10));

        //     Func<MyDelegate, int, int, int> myAction = Calc;


        // }
#endregion

#region 
        // class Product
        // {
        //     public string Name { get; set; }
        //     public int Price { get; set; }
        // }

        // static void Main(string[] args)
        // {
        //     // List<Product> items = new()
        //     // {
        //     //     new() { Name = "갑옷", Price = 600 },
        //     //     new() { Name = "반지", Price = 600 },
        //     //     new() { Name = "무기", Price = 600 },
        //     //     new() { Name = "벨트", Price = 600 },
        //     //     new() { Name = "바지슬레이어우앱", Price = 20040225 }
        //     // };

        //     // //items.Sort(SortProduct);
        //     // //items.RemoveAll(Func);

        //     // //items.Sort(delegate (Product x, Product y) { return x.Name.CompareTo(y.Name); });
        //     // items.Sort((x, y) => x.Name.CompareTo(y.Name));
        //     // items.RemoveAll(x => x.Price < 700);

        //     // items.ForEach(x => { System.Console.WriteLine(x.Name + " " + x.Price); });
        // }

        // static int SortWithPrice(Product a, Product b)
        // {
        //     return a.Price.CompareTo(b.Price);
        // }

        // static bool Func(Product obj)
        // {
        //     return obj.Price < 700;
        // }

        // static int SortWithName(Product a, Product b)
        // {
        //     return b.Name.CompareTo(a.Name);
        // }

        // static int SortProduct(Product a, Product b)
        // {
        //     int compared = a.Price.CompareTo(b.Price);

        //     return compared == 0 ? a.Name.CompareTo(b.Name) : compared;
        // }


        // public delegate void TestDelegate();

        // static void Main(string[] args)
        // {
        //     TestDelegate delegateA = TestMethod;
        //     TestDelegate delegateB = delegate () {};
        //     TestDelegate delegateC = () => {};

        //     delegateA();
        //     delegateB();
        //     delegateC();
        // }

        // static void TestMethod() {}
#endregion

        // class Student
        // {
        //     public string Name { get; set; }
        //     public double Score { get; set; }

        //     public Student(string name, double score)
        //     {
        //         this.Name = name;
        //         this.Score = score;
        //     }


        //     public override string ToString()
        //     {
        //         return this.Name + " : " + this.Score;
        //     }
        // }

        // class Students
        // {
        //     private List<Student> listOfStudnet = new();

        //     public delegate void PrintProcess(Student list);

        //     public void Add(Student student)
        //     {
        //         listOfStudnet.Add(student);
        //     }

        //     public void Print()
        //     {
        //         Print((student) =>
        //         {
        //             System.Console.WriteLine(student);
        //         });
        //     }

        //     public void Print(PrintProcess process)
        //     {
        //         listOfStudnet.ForEach(x => process(x));
        //     }


        //     static void Main(string[] args)
        //     {
        //         Students students = new();
        //         students.Add( new("한우엽", 10.0));
        //         students.Add( new("명재문", 10.0));

        //         students.Print();

        //         students.Print(s =>
        //         {
        //             System.Console.WriteLine();
        //             System.Console.WriteLine("이름: " + s.Name);
        //             System.Console.WriteLine("이름: " + s.Score);
        //         });
        //     }
        //}


    public delegate void SendString(string msg);
    static void Main(string[] args)
    {
        SendString sayHello, sayGoodbye, multiDelegate;

        sayHello = Hi;
        sayGoodbye = Bye;

        multiDelegate = sayHello + sayGoodbye;

        multiDelegate("Han");

        multiDelegate -= sayGoodbye;

        multiDelegate("Han");


    }

    static void Hi(string msg)
    {
        System.Console.WriteLine("Hi " + msg + "!");
    }
    
    static void Bye(string msg)
    {
        System.Console.WriteLine("Bye " + msg + "!");
    }


    }
}