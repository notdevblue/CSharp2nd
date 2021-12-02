using System;
using System.Reflection;

namespace CSharp1202
{
    #region 예제
    // class MainApp
    // {
    //     static void PrintInterfaces(Type type)
    //     {
    //         Console.WriteLine("-------- Interfaces -------- ");

    //         Type[] interfaces = type.GetInterfaces();
    //         foreach (Type i in interfaces)
    //             Console.WriteLine("Name:{0}", i.Name);

    //         Console.WriteLine();
    //     }

    //     static void PrintFields(Type type)
    //     {
    //         Console.WriteLine("-------- Fields -------- ");

    //         FieldInfo[] fields = type.GetFields(
    //             BindingFlags.NonPublic |
    //             BindingFlags.Public |
    //             BindingFlags.Static |
    //             BindingFlags.Instance);

    //         foreach (FieldInfo field in fields)
    //         {
    //             String accessLevel = "protected";
    //             if (field.IsPublic) accessLevel = "public";
    //             else if (field.IsPrivate) accessLevel = "private";

    //             Console.WriteLine("Access:{0}, Type:{1}, Name:{2}",
    //                 accessLevel, field.FieldType.Name, field.Name);
    //         }

    //         Console.WriteLine();
    //     }

    //     static void PrintMethods(Type type)
    //     {
    //         Console.WriteLine("-------- Methods -------- ");

    //         MethodInfo[] methods = type.GetMethods();
    //         foreach (MethodInfo method in methods)
    //         {
    //             Console.Write("Type:{0}, Name:{1}, Parameter:",
    //                 method.ReturnType.Name, method.Name);

    //             ParameterInfo[] args = method.GetParameters();
    //             for (int i = 0; i < args.Length; i++)
    //             {
    //                 Console.Write("{0}", args[i].ParameterType.Name);
    //                 if (i < args.Length - 1)
    //                     Console.Write(", ");
    //             }
    //             Console.WriteLine();
    //         }
    //         Console.WriteLine();
    //     }

    //     static void PrintProperties(Type type)
    //     {
    //         Console.WriteLine("-------- Properties -------- ");

    //         PropertyInfo[] properties = type.GetProperties();
    //         foreach (PropertyInfo property in properties)
    //             Console.WriteLine("Type:{0}, Name:{1}",
    //                 property.PropertyType.Name, property.Name);

    //         Console.WriteLine();
    //     }

    //     static void Main(string[] args)
    //     {
    //         //int a = 0;
    //         string a = "";
    //         Type type = a.GetType();  // Type

    //         PrintInterfaces(type);
    //         PrintFields(type);
    //         PrintProperties(type);
    //         PrintMethods(type);
    //     }

    #endregion

    // class MyClass
    // {
    //     int num = 0;
    //     public string myName = "Han";

    //     public MyClass(int num = 1)
    //     {
    //         this.num = num;
    //     }
    // }

    class Profile
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public void Print()
        {
            System.Console.WriteLine($"{Name}, {Phone}");
        }
    }

    class Program
    {

        static void Main2(string[] args)
        {
            // 리플랙션
            Type type = typeof(Profile);
            Profile profile = (Profile)Activator.CreateInstance(type);
            profile.Name = "Han";
            profile.Phone = "010-2754-4749";
            MethodInfo method = type.GetMethod("Print");
            method.Invoke(profile, null); // 매개변수 없으므로 null


            // int a = 5;
            // MyClass myClass = new MyClass(2);

            // Type type = a.GetType();
            // FieldInfo[] fields = type.GetFields(); // int 가 가지고 있는 변수들
            // MethodInfo[] methods = type.GetMethods(); // int 가 가지고 있는 함수들
            // MemberInfo[] members = type.GetMembers(); // int 가 가지고 있는 멤버들

            // foreach (FieldInfo field in fields)
            // {
            //     System.Console.WriteLine("Type:{0} Name:{1}", field.FieldType.Name, field.Name);
            // }

            // System.Console.WriteLine();

            // foreach (MethodInfo field in methods)
            // {
            //     System.Console.WriteLine("Type:{0} Name:{1}", field.MemberType, field.Name);
            // }

            // foreach (FieldInfo field in members)
            // {
            //     System.Console.WriteLine("Type:{0} Name:{1}", field.MemberType, field.Name);
            // }

            // System.Console.WriteLine();

            // FieldInfo[] fields2 = myClass.GetType().GetFields(BindingFlags.NonPublic |
            //     BindingFlags.Public |
            //     // BindingFlags.Static |
            //     BindingFlags.Instance
            //     );

            // foreach (FieldInfo field in fields2)
            // {
            //     System.Console.WriteLine("Type:{0} Name:{1}", field.FieldType.Name, field.Name);
            // }


        }
    }
}