using System;

namespace DebugBase
{
    class Program
    {
        static void Print(int value)
        {
            Console.WriteLine(value);
        }
        static int AddAndPrint(int a, int b)
        {
            int ret = a + b;
            Print(ret);
            return ret;
        }
        static void Main(string[] args)
        {
            Program.AddAndPrint(5, 15);
            Program.AddAndPrint(6, 17);
            Program.AddAndPrint(3, 11);
            Program.AddAndPrint(12, 31);
            Program.AddAndPrint(10, 20);
            // Console.WriteLine(ret);
        }
    }
}
