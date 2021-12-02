using System;
using System.Reflection;

namespace DynamicInstance
{
    class Profile
    {
        private string name;
        private string phone;
        private int age;

        public Profile() { name = ""; phone = ""; age = 0; }

        public Profile(string name, string phone, int age)
        {
            this.name = name;
            this.phone = phone;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine($"{name}, {phone}. {age}");
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("DynamicInstance.Profile"); //class Type 얻어오기 
            MethodInfo methodInfo = type.GetMethod("Print");
            PropertyInfo nameProperty = type.GetProperty("Name");
            PropertyInfo phoneProperty = type.GetProperty("Phone");
            PropertyInfo ageProperty = type.GetProperty("Age");

            //instance 생성후 메소드 실행
            object profile = Activator.CreateInstance(type, "홍길동", "123-1234", 10);
            methodInfo.Invoke(profile, null);

            //instance 생성후 속성 할당
            profile = Activator.CreateInstance(type);
            nameProperty.SetValue(profile, "박찬호", null);
            phoneProperty.SetValue(profile, "997-5511", null);
            ageProperty.SetValue(profile, 18, null);

            Console.WriteLine("{0}, {1}. {2}",
                nameProperty.GetValue(profile, null),
                phoneProperty.GetValue(profile, null),
                ageProperty.GetValue(profile, null));
                
        }
    }
}