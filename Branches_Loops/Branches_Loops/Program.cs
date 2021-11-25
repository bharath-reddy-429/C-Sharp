using System;

namespace Branches_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            for(int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    c+= i;
                }
            }
            Console.WriteLine(c);
        }
    }
}
