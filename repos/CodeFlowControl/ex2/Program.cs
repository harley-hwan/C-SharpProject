using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 별 찍기
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j <= i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
