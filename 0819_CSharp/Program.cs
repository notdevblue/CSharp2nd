// 20219 한우엽

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq; 

namespace _0819_CSharp
{
    class Program
    {
        #region 5교시 함수

        // static int Abs(int num)
        // {
        //     return num < 0 ? -num : num;
        // }
        // static void Abs2(ref int num)
        // {
        //     num = num < 0 ? -num : num;
        // }

        // static bool Sum(int num1, int num2, out int result)
        // {
        //     result = num1 + num2;
        //     return result > 0 ? true : false;
        // }


        #endregion

        #region 6교시 함수나 클레스

        // static void Sum(int num1 = 1, int num2 = 2)
        // {
        //     System.Console.WriteLine(num1 + num2);
        // }

        // params => ... (C++ 메크로) 와 비슷한
        // static string MaxString(params string[] strings)
        // {
        //     int maxidx = 0;
        //     int maxLength = -1;
        //     for (int i = 0; i < strings.Length; ++i)
        //     {
        //         if (maxLength < strings[i].Length)
        //         {
        //             maxLength = strings[i].Length;
        //             maxidx = i;
        //         }
        //     }
        //     return strings[maxidx];
        // }

        // static bool IsValid(string nickname)
        // {
        //     for (int i = 0; i < nickname.Length; ++i)
        //     {
        //         if (char.IsUpper(nickname[i]) && !int.TryParse(nickname[i].ToString(), out int temp))
        //         {
        //             return false;
        //         }
        //     }

        //     return true;
        // }

        // class MyMath
        // {
        //     static public int Abs(int num)
        //     {
        //         return num < 0 ? -num : num;
        //     }
        // }

        // static Constructor() {}
        // 정적 접근 할때 생성자가 불리게 됨

        // 앝은 복사(shallow copy) = 주소만
        // 깊은 복사(deep copy)    = 값을 전부

        // class SquareCalculator
        // {
        //     public float this[float num] // 접근지정자 반환타입 this[인덱스들] {get; set;}
        //     {
        //         get
        //         {
        //             return num * num;
        //         }
        //     }
        // }


        #endregion

        static void Main(string[] args)
        {
            #region 4교시
            // 아 이 전껄 지웠
            // Console.WriteLine(int.MaxValue);
            // Console.WriteLine(int.MinValue);

            // int A = 10;
            // int B = 5;
            // System.Console.WriteLine((A + B) / 2.0f);

            // System.Console.WriteLine('s' + 0);

            // int num = 100;
            // System.Console.WriteLine((char)num);

            // int a = 100;
            // System.Console.WriteLine(Convert.ToString(a, 2));
            // Convert.Tostring(숫자, 진법);
            // 진법에 2 또는 8, 16 을 넣을 수 있다.

            // System.Console.WriteLine(((84 + 63 + 70) / 3.0).ToString("0.00"));
            // // Tostring("0.00") => 소수점 변환 가능
            // System.Console.WriteLine("{0:0.00}", 10 / 3.0f);
            // // {0::0.00} 도 가능함

            // DateTime past = new DateTime(2000, 1, 1);
            // TimeSpan ts = DateTime.Now - past;
            // System.Console.WriteLine((int)ts.TotalDays);
            // TimeSpan => 말 그대로 지나간시간 무튼 그런것

            // string s = "of the people, by the people, for the people";
            // string[] strings = s.Split(", ");
            // foreach (var sa in strings)
            // {
            //     System.Console.WriteLine(sa);
            // }

            // while(true)
            // {
            //     if(int.TryParse(Console.ReadLine(), out int res))
            //     {
            //         System.Console.WriteLine(res);
            //         break;
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("다시 입력하세요.");
            //     }
            // }

            // || 만 있을시 앞에 true 라면 뒤는 아예 연산하지

            #endregion

            #region 5교시

            // int x = 1;
            // System.Console.WriteLine($"{x++}, {x}, {++x}, {x}");

            // 0001
            // 0011

            // 0001
            // 0011
            // 0010

            // DateTime date = new DateTime(2000, 1, 1);
            // TimeSpan span = new DateTime(2000, 12, 31) - date;

            // System.Console.WriteLine(span.TotalSeconds);

            // double totalSeconds = TimeSpan.FromDays(365).TotalSeconds;
            // // FromDays(365) 365일의 시간
            // System.Console.WriteLine(totalSeconds);

            // for (int i = 1; i <= 100; ++i)
            // {
            //     if(i % 2 == 1)
            //     {
            //         System.Console.WriteLine(i);
            //     }
            // }

            // for (int i = 1; i <= 100; i += 2)
            // {
            //     System.Console.WriteLine(i);
            // }

            // for (int i = 1; i <= 100; ++i)
            // {
            //         if (i % 2 == 0)
            //             continue;

            //         System.Console.WriteLine(i);
            // }

            // int a = 100;
            // if(a > 0)
            // {
            //     System.Console.WriteLine("양수");
            // }
            // else if (a < 0)
            // {
            //     System.Console.WriteLine("음수");
            // }
            // else
            // {
            //     System.Console.WriteLine("0");
            // }

            // int a = 0;
            // System.Console.WriteLine(a == 0 ? "0" : (a > 0 ? "양수" : "음수"));

            // while (true)
            // {
            //     ConsoleKey key = Console.ReadKey().Key;

            //     switch(key)
            //     {
            //         case ConsoleKey.UpArrow:
            //             System.Console.WriteLine("up");
            //             break;

            //         case ConsoleKey.DownArrow:
            //             System.Console.WriteLine("Down");
            //             break;

            //         case ConsoleKey.LeftArrow:
            //             System.Console.WriteLine("Left");
            //             break;

            //         case ConsoleKey.RightArrow:
            //             System.Console.WriteLine("Right");
            //             break;
            //     }
            // }

            // string[] fruits = { "사과", "배", "레식샌" };
            // fruits.ToList().ForEach(e => Console.Write($"{e} "));
            // for (int i = 0; i < fruits.Length; ++i)
            // {
            //     System.Console.WriteLine(fruits[i]);
            // }
            // for (int i = fruits.Length - 1; i >= 0; --i)
            // {
            //     System.Console.WriteLine(fruits[i]);
            // }

            // string str = "고구마 토마토";
            // for (int i = str.Length - 1; i >= 0; --i)
            // {
            //     Console.Write(str[i]);
            // }
            // System.Console.WriteLine();



            #endregion

            #region 5교시_2

            // int num = Abs(-10);
            // System.Console.WriteLine(num);

            // int a = -2;
            // Abs2(ref a);
            // System.Console.WriteLine(a);

            // int res;
            // System.Console.WriteLine(Sum(100, -200, out res));
            // System.Console.WriteLine(res);

            // 메게변수 안에서 선언된 것은 스코프 안에서 전부볼수잇음

            #endregion

            #region 6교시

            // Sum(1);
            // Sum(1, 2);

            // string str = MaxString("와센즈", "아시는구나", "ㅣ야아아앙알미ㅏㄴㅇ럼ㄴㅇ");
            // System.Console.WriteLine(str);

            // System.Console.WriteLine(IsValid("wooyeop0225"));
            // System.Console.WriteLine(IsValid("Han"));

            // int a = 10;
            // System.Console.WriteLine(MyMath.Abs(a));
            // System.Console.WriteLine(MyMath.Abs(-a));

            // testB = new Test();
            // testB.value = testA.value;

            // public int Level { get; set; }

            // SquareCalculator square = new SquareCalculator();
            // System.Console.WriteLine(square[5]);

            #endregion


        }
    }
}
