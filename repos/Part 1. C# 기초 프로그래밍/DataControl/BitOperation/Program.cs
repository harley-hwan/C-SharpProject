using System;

namespace BitOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int id = 123;
            int key = 401;

            int a = id ^ key;
            int b = a ^ key;
            // <<   >>  &(and)   !(not)   ^(xor)   ~(not)
            num = num << 3;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
