using System;


namespace CSharp_1216
{
    class Program
    {
        // class MyClass 
        // {
        //     public void FuncAAA() { }
        // }

        // class Duck
        // {
        //     public void Walk() { System.Console.WriteLine(this.GetType() + ".Walk"); }
        //     public void Swim() { System.Console.WriteLine(this.GetType() + ".Swim"); }
        //     public void Quack() { System.Console.WriteLine(this.GetType() + ".Quack"); }
        // }
        // class Jemmun : Duck { }

        // class Robot
        // {
        //     public void Walk() { System.Console.WriteLine("Robot.Walk"); }
        //     public void Swim() { System.Console.WriteLine("Robot.Swim"); }
        //     public void Quack() { System.Console.WriteLine("Robot.Quack"); }
        // }

        // static void Print(dynamic val)
        // {
        //     System.Console.WriteLine(val.GetType());
        // }

        static void Print(dynamic obj)
        {
            try
            {
                System.Console.WriteLine(obj.Name);
                System.Console.WriteLine(obj.Age);
                System.Console.WriteLine(obj.Score);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {

            Print(new { Name = "as", Age = 10 });

            // Print(10);
            // Print(10.1);
            // Print(10.02f);
            // Print("Wa");
            // Print(true);
            // Print(DateTime.Now);

            // dynamic[] arr = new dynamic[] { new Duck(), new Jemmun(), new Robot() };

            // foreach(var duck in arr)
            // {
            //     duck.Walk();
            //     duck.Swim();
            //     duck.Quack();
            // }


            // object o1 = 10;
            // o1 = "asdasd";
            // object o2 = "asdasd";
            // o2 = o2 + 10;
            // o2 = (int)o2 + 10;

            // dynamic v1 = 10;
            // dynamic v2 = "asasd";
            // v2 = v2 + 10;

            // System.Console.WriteLine(o2);
            // System.Console.WriteLine(v2);


            // dynamic obj = new MyClass();
            // obj.FuncAAA();
            // obj.FuncBBB();

            // var v1 = 10;
            // var v2 = "string";
            // var v3 = null;
            // dynamic v3 = null;

            // dynamic v3 = "String";
            // System.Console.WriteLine(v3);
            // v3 = 5;
            // System.Console.WriteLine(v3);

            // System.Console.WriteLine();
        }

    }
}
