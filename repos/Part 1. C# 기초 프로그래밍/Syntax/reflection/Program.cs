using System;
using System.Reflection;

namespace reflection
{
    class Program
    {
        class Important : System.Attribute
        {
            string message;

            public Important(string message) { this.message = message; }
        }
        class Monster
        {
            // hp입니다. 중요한 정보입니다.        // 일반적으로, 주석은 컴파일도 안됨.
            [Important("Very Important")]        // 컴퓨터가 인식할 수 있는 주석의 개념.
            public int hp;
            protected int attack;
            private float speed;

            void Attack() { }
        }
        static void Main(string[] args)
        {
            // Reflection : X-Ray
            Monster monster = new Monster();

            Type type = monster.GetType();

            var fields = type.GetFields(System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic)
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";

                var attributes = field.GetCustomAttributes();

                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            }
               
                
        }
    }
}
