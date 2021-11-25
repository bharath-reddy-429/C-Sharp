using System;

namespace Branches
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            if (a + b > 30) Console.WriteLine("a+b is greater than 30");
            else if (a + b < 30) Console.WriteLine("a+b is less than 30");
            else Console.WriteLine("a+b is Equal to 30");
        }
    }
}
