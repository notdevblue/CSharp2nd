using System;
using System.Linq;

namespace _1007_CSharp
{
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



        }
    }
}
