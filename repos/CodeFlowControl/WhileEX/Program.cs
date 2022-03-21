using System;

namespace WhileEX
{
    class Program
    {
        static void Main(string[] args)
        {
            // while 반복문
            int count = 5;
            string answer;

            while (count > 0)
            {
                Console.WriteLine("Hello World!");
                count--;
            }

            do
            {
                Console.WriteLine("(y/n) : ");
                answer = Console.ReadLine();
            } while (answer != "y");

            Console.WriteLine("end");
        }
    }
}
