using System;
using System.Collections.Generic;
using System.Linq;

namespace _1007_CSharp
{

    public static class IntergerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; ++i)
            {
                result = result * myInt;
            }

            return result;
        }

        public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            foreach (T item in list)
            {
                action(item);
            }
        }
    }

    class Program
    {
        #region 5교시
        // class Class
        // {
        //     public string Name { get; set; }
        //     public int[] Score { get; set; }
        // }
        // class Profile
        // {
        //     public string Name { get; set; }
        //     public int Height { get; set; }
        // }
        // class Profile
        // {
        //     public string Name { get; set; }
        //     public int Height { get; set; }
        // }
        // class Product
        // {
        //     public string Title { get; set; }
        //     public string Star { get; set; }
        // }
        #endregion

        static void Main(string[] args)
        {
            #region 5교시
            // int[] numbers = { 9, 2, 3, 5, 7, 1, 4, 8, 1, 8, 2, 4, 6, 10 };
            // var result = from n in numbers
            //              where (n & 1) == 0
            //              orderby n
            //              select n;
            // result.ToList().ForEach(e => System.Console.Write(e));
            // System.Console.WriteLine();

            // Class[] arrClass = {
            //     new Class(){Name="1반", Score = new[] {50,70,90,10}},
            //     new Class(){Name="2반", Score = new[] {90,0,20,14}},
            //     new Class(){Name="3반", Score = new[] {94,87,38,59}},
            //     new Class(){Name="4반", Score = new[] {98,72,88,42}}
            // };
            // var result = from c in arrClass
            //              from s in c.Score
            //              where s < 60
            //              orderby s
            //              select new
            //              {
            //                  Class = c.Name,
            //                  Score = s
            //              };
            // result.ToList().ForEach(e => System.Console.WriteLine(e));
            // System.Console.WriteLine();

            // Profile[] arrProfile = {
            //     new Profile(){Name="A", Height=185},
            //     new Profile(){Name="B", Height=176},
            //     new Profile(){Name="C", Height=172},
            //     new Profile(){Name="D", Height=164},
            //     new Profile(){Name="E", Height=188},
            //     new Profile(){Name="P", Height=154},
            //     new Profile(){Name="G", Height=160}
            // };
            // var output = from p in arrProfile
            //              orderby p.Height
            //              group p by p.Height < 170 into g
            //              select new
            //              {
            //                  GroupKey = g.Key,
            //                  Profile = g
            //              };
            // output.ToList().ForEach(e => {
            //     System.Console.WriteLine(e.GroupKey);
            //     foreach (var item in e.Profile)
            //     {
            //         System.Console.WriteLine(item.Name + " " + item.Height);
            //     }
            //     System.Console.WriteLine();
            // });

            // Profile[] arrProfile = {
            //     new Profile(){Name="A", Height=185},
            //     new Profile(){Name="B", Height=176},
            //     new Profile(){Name="C", Height=172},
            //     new Profile(){Name="D", Height=164},
            //     new Profile(){Name="E", Height=188},
            //     new Profile(){Name="P", Height=154},
            //     new Profile(){Name="G", Height=160}
            // };
            // Product[] arrProduct = {
            //     new Product(){Title="겜마고", Star="A"},
            //     new Product(){Title="부산행", Star="D"},
            //     new Product(){Title="내가만들고싶은게임을만들수있는곳", Star="G"},
            //     new Product(){Title="아이키커", Star="P"},
            //     new Product(){Title="와센즈", Star="E"},
            //     new Product(){Title="리섹샌", Star="C"},
            //     new Product(){Title="이거지", Star="D"}
            // };
            // var output = from profile in arrProfile
            //              join product in arrProduct on profile.Name equals product.Star
            //              select new
            //              {
            //                  Name = product.Star,
            //                  Title = product.Title,
            //                  Height = profile.Height
            //              };
            // var output = from profile in arrProfile
            //              join product in arrProduct on profile.Name equals product.Star into ps
            //              from product in ps.DefaultIfEmpty(new Product() { Title = "어림도없지" }) // 만약 빈 것이 있다면 이걸 채워 줌
            //              select new
            //              {
            //                  Name = profile.Name,
            //                  Title = product.Title,
            //                  Height = profile.Height
            //              };
            // output.ToList().ForEach(e => System.Console.WriteLine(e.Name + " " + e.Title + " " + e.Height));


            #endregion 5교시

            #region 6교시
            // var output = from p in arrProfile
            //              orderby p.Height
            //              group p by p.Height < 170 into g
            //              select new
            //              {
            //                  GroupKey = g.Key == true ? "170미만" : "170이상",
            //                  Count = g.Count(),
            //                  Max = g.Max(profile => profile.Height),
            //                  Min = g.Min(profile => profile.Height),
            //                  Average = g.Average(profile => profile.Height)
            //              };
            // output.ToList().ForEach(e =>{
            //     System.Console.WriteLine("{0} {1} {2} {3} {4}", e.GroupKey, e.Count, e.Max, e.Min, e.Average);
            // });

            // var arr = new int[100];

            // for (var i = 0; i < arr.Length; ++i)
            // {
            //     arr[i] = i * i;
            // }
            // foreach (var item in arr)
            // {
            //     System.Console.WriteLine(item);
            // }
            // var result = from i in Enumerable.Range(0, 100) // 0부터 99까지의 데이터를 만듬
            //              select i * i;
            // foreach (var item in result)
            // {
            //     System.Console.WriteLine(item);
            // }
            // result.ToList().ForEach(e => System.Console.WriteLine(e));
            // result.ForEach(e => System.Console.WriteLine(e));

            // int a = 2;
            // System.Console.WriteLine(a.Square());
            // System.Console.WriteLine(a.Power(10));

            // var sheet = new[] {
            //     new List<string>() {"a", "10", null, "30"},
            //     new List<string>() {"b", "10", "50", "40"},
            //     new List<string>() {"c", "20", "60", "60"},
            //     new List<string>() {"a", "30", "40", "70"}
            // }

            // var result = sheet
            //     .Where(w => x[0] == "a")
            //     .FirstOrDefault()
            //     .

            int a = 0;
            var list = new int[] { 10, 20, 30, 40, 45, 50 };
            var result = list
                .Where(x =>
                {
                    System.Console.WriteLine($"[Where] {x}"); ++a;
                    return x > 30;
                })
                .Select(x =>
                {
                    System.Console.WriteLine($"[Select] {x}"); ++a;
                    return x * x;
                });


            //System.Console.WriteLine(string.Join(",", result));
            System.Console.WriteLine(a);

            #endregion




        }
    }
}
