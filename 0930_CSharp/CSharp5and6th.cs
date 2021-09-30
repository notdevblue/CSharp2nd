using System;
using System.Collections.Generic;
using System.Linq;


namespace CSharp5ands6th
{
    class Program
    {
        static public int[] SelectEven(int[] input)
        {
            return (from item in input
                    where item % 2 == 0
                    select item).ToArray<int>();
        }
        static public List<int> SelectEven(List<int> input)
        {
            return (from item in input
                    where item % 2 == 0
                    select item).ToList<int>();
        }


        static void Main(string[] args)
        {
            // List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // (from item in input where item > 5 && (item & 1) != 1 orderby item descending select item).ToList().ForEach(e => System.Console.Write(e + " "));
            // System.Console.WriteLine();

            // (from item in input where item > 5 && (item & 1) != 1 orderby item ascending select item).ToList().ForEach(e => System.Console.Write(e + " "));
            // System.Console.WriteLine();

            // IEnumerable<int> output = from item in input
            //                           where item % 2 == 0
            //                           orderby item descending
            //                           select item;

            // SelectEven(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).ToList().ForEach(e => System.Console.Write(e + " "));
            // System.Console.WriteLine();
            // SelectEven(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).ForEach(e => System.Console.Write(e + " "));
            // System.Console.WriteLine();


            // var a = new { A = "a" };

            // class ClassA
            // {
            //     public int A;
            //     public int B;
            //     public int C;
            // }


            // var output = from item in input
            //                  where (item & 1) != 0
            //                  select new
            //                  {
            //                      A = item * 2,
            //                      B = item * item,
            //                      C = item
            //                  };

            // output.ToList().ForEach(e => System.Console.WriteLine($"A: {e.A} B: {e.B} C: {e.C}"));

            // var output = from item in input
            //              select new
            //              {
            //                  Num = item,
            //                  IsEven = (item & 1) != 1
            //              };

            // output.ToList().ForEach(e => System.Console.Write(e.Num + " " + (e.IsEven ? "짝" : "홀") + " "));

            // System.Console.WriteLine();

            // var obj = new
            // {
            //     Name = "Han",
            //     Age = 18
            // };

            // System.Console.WriteLine(obj.Name + " " + obj.Age);

            // var v = new[]
            // {
            //     new { Name = "Han", Age = 18, Phone="010-2754-4749" },
            //     new { Name = "Jan", Age = 18, Phone="010-2754-4749" },
            //     new { name = "San", Age = 18, Phone="010-2754-4749" },
            // };

            // var v = new[]
            // {
            //     new {Name = "Han", Age = 32, Phone = "010-2754-4749"},
            //     new {Name = "Jan", Age = 51, Phone = "010-2754-4749"},
            //     new {Name = "San", Age = 30, Phone = "010-2754-4749"}
            // };

            // var output = from item in v
            //              where item.Age > 30
            //              select new
            //              {
            //                  Name = item.Name,
            //                  Phone = item.Phone
            //              };


            // output.ToList().ForEach(e => System.Console.WriteLine(e.Name + " " + e.Phone));

            // var list = v.Where(p => p.Age > 30).Select(p => new { p.Name, p.Phone }).ToList();

            // list.ForEach(e => System.Console.WriteLine(e.Name + " " + e.Phone));

            // List<Product> input = new()
            // {
            //     new() { Name = "고구마", Price = 1500 },
            //     new() { Name = "사과", Price = 2400 },
            //     new() { Name = "바나나", Price = 1000 },
            //     new() { Name = "배", Price = 3000 },
            //     new() { Name = "감자", Price = 1000 },
            //     new() { Name = "토마토", Price = 2000 },
            //     new() { Name = "옥수수", Price = 1500 },
            //     new() { Name = "자두", Price = 500 },
            // };

            // var output = from a in input
            //              where a.Price > 1500
            //              orderby a.Name ascending
            //              select a;

            // output.ToList().ForEach(e => System.Console.WriteLine(e.Name + " " + e.Price));

            // 연습문제
            /*
            1.
                Linq, 
                where
                orderby
                익명 객체
                XML
            2.
                O
                X 자동으로 오름차순으로 됨
                X 익명 객체가 있음
                O
            */

            //3 ~ 7
            // List<int> input = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // (from item in input where item > 4 select item).ToList().ForEach(e => System.Console.Write(e + " "));
            // (from item in input where item % 4 == 1 select item).ToList().ForEach(e => System.Console.Write(e + " "));
            // (from item in input where item % 4 == 1 orderby item select item).ToList().ForEach(e => System.Console.Write(e + " "));
            // (from item in input where item % 4 == 1 orderby item descending select item).ToList().ForEach(e => System.Console.Write(e + " "));
            // from item in products orderby item.Name select item
            // from item in products where item.Price < 2000 orderby item.Price select item
            // from item in products where item.Price < 2000 orderby item.Price descending select item

        } 

        // class Product
        // {
        //     public string Name { get; set; }
        //     public int Price { get; set; }
        // }
    }
}