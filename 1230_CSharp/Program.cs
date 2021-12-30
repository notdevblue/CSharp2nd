using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1230CSharp
{
    class Program
    {
//        static public bool IsAlphabet(string strValue)
//        {
//            if(string.IsNullOrEmpty(strValue))
//                return false;
//
//            Regex regex = new Regex("");
//        }

//        public static class CommonExtensions
//        {
//            public static bool IsValidEmail(this string str) => 
//                !string.IsNullOrWhiteSpace(str) && 
//                new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w);


//        class MyClass
//        {
//            private string name = "";
//            private string message = "";
//            public string Name => name;

//            public MyClass(string val) => Name = val;
//            public int Add(int a, int b) => a + b;
//            public int Func() => 0;


//            public void Print() => Console.WriteLine(message);
//            public SubClass GetSubClass()
//            {
//                return new SubClass
//            }

 //       }

        static int[] GetAllScores() => new int[] {10, 20, 30};


        static IEnumerable<int> GetScores()
        {
           int[] scores = new int[] { 10, 20, 30 };
           int total = 0;
//           yield return scores[0];
//           yield return scores[1];
//           yield return scores[2];

            for(int i = 0; i < scores.Length; ++i) {
               total += scores[i];
               if(total > 50) yield break;

                  yield return total;
            }
        }

        static IEnumerator TestIEnumerator()
        {
           yield return 1;
           yield return 2;
           yield return 3;
        }

        class MyList
        {
           private int[] data = { 1, 2, 3, 4, 5, 6 };

            public IEnumerator GetEnumerator() // for foreach
            {
               int i = 0;
               while(i < data.Length) {
                  yield return data[i++];
               }
            }
         }

         class Shape { public string value = "a"; }
         class Circle : Shape { public Shape shape = new Shape(); }

         partial interface IDoable { string Name { get; set; } }
         partial interface IDoable { void Do(); }

         public class DoClass : IDoable
         {
            public string Name { get; set; }
            public void Do() => Console.WriteLine(Name ?? "Han");
         }

         static (int cnt, int sun, double avg) Calculate(List<int> list)
         {
            int cnt = 0;
            int sum = 0;
            double avg = 0.0;

            foreach (int n in list)
            {
                sum += n;
            }

            cnt = list.Count;
            avg = (double)sum / cnt;

            return (cnt, sum, avg); 
         }

        static void Main(string[] args)
        {

            List<int> list = new() { 1, 2, 3, 4, 5, 6 };
            
            (int aa, int bb, double cc) = Calculate(list);

            Console.WriteLine(aa + " " + bb + " " + cc);

            return;

            int cnt = 0;
            int sum = 0;
            double avg = 0.0;

            foreach(int n in list) {
               sum += n;
            }
            cnt = list.Count;

            Console.WriteLine(cnt);
            Console.WriteLine(sum);
            Console.WriteLine(avg = (double)sum / cnt);
               


            Circle circle = new Circle();
            string a = "d";
            circle.shape.value = null;
            a = circle?.shape?.value ?? "d";

            int num = 5;
            int? nulable_num = null;
            Nullable<int> another_nullable_num = null;

            DoClass doclass = new();
            doclass.Name = "Jan";
//            doclass.Do();
            
//            Console.WriteLine(a);

//            var list = new MyList();
//            foreach(var item in list) {
//               Console.WriteLine(item);
//            }

//            IEnumerator it = list.GetEnumerator();
//            while(it.MoveNext()) {
//               Console.WriteLine(it.Current);
//            }

//            IEnumerator ie = TestIEnumerator();
//            while(ie.MoveNext()) { // true when data is not null
//               Console.WriteLine(ie.Current);
//            }

//           foreach(var a in GetScores()) {
//              Console.WriteLine(a);
//           }

//            foreach(var a in GetAllScores()) {
//                Console.WriteLine(a);
//            }
        
            //GetAllScores();           


            //string str = "Gangnamvil serchoApart APT";
            //Regex regex = new Regex(@"(APT|Apart)");
            //string str = "<ul><li>HomePage</li><li>Menu</li></ul>";
            //Regex regex = new Regex(@"<li>(\w+)</li>");
            //string str = "02-522-2345; 032-123-6919";
            //Regex regex = new Regex(
            //MatchCollection mc = regex.Matches(str);
            //foreach(Match m in mc) {
            //    Group g = m.Groups[1];
            //    Console.WriteLine("{0}:{1}", g.Index, g.Value);
            //}


            //string str = "a123";
            //Regex regex = new Regex(@"^a\d{3,}$");
            //string str = "KangGu";
            //Regex regex = new Regex(@"^Kang\w*Gu$");
            //string str = "018-1234-1234";
            //Regex regex = new Regex(@"^01[01678]-[0-9]{4}-[0-9]{4}$");
            //string pattern @"(Mr\.? | Mrs\.? | Miss | Ms\.?)";
            //string[] names = {
            //    "Mr. Han",
            //    "Ms. R6Sans",
            //    "Wooyeop",
            //    "Miss Korea"
            //};
            //string str = "Eng@Kor1234!@#$**이야아이";
            //str = Regex.Replace(str, @"[^0-9]", "");
            //str = Regex.Replace(str, @"[^a-zA-Z]", "");
            //str = Regex.Replace(str, @"[^가-힇]", "");
            //str = Regex.Replace(str, @"\W", "");
            //Console.WriteLine(str);
            //return;

            //if(regex.IsMatch(str)) {
            //    Console.WriteLine("Match");
            //} else {
            //    Console.WriteLine("UnMatch");
            //}


            /*
            string phonenum = "010-1802-9950";
            Regex regex = new Regex(@"^\d{3}-\d{4}-\d{4}$");
            if(regex.IsMatch(phonenum)) {
                Console.WriteLine("Match");
            } else {
                Console.WriteLine("Fail");
            }
            */

            //String name = "1234";
            //Regex regex = new Regex(@"^[a-zA-Z]{3, 5}$");
            //if(regex.IsMatch(name)) {
            //    Console.WriteLine("Match");
            //}




            //string str = "서울시 강남구 역삼동 강남아파트";
            //Regex regex = new Regex("강남");
            // Match m = regex.Match(str);

            // while(m.Success) {
            //     System.Console.WriteLine("{0}:{1}", m.Index, m.Value);
            //     m = m.NextMatch();
            // }

            // return;

            //MatchCollection mc = regex.Matches(str);

            //mc.ToList().ForEach(e => {
            //    if(e.Success) System.Console.WriteLine("{0}:{1}", e.Index, e.Value);
            //});

            //Regex regex2 = new Regex(" ");
            //string[] strArray = regex2.Split(str); // splits str with new Regex("this");

            //strArray.ToList().ForEach(e => {
            //        Console.WriteLine(e);
            //});
        }
    }
}
