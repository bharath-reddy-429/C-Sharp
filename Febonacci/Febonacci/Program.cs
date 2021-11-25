using System;
using System.Collections.Generic;

namespace Febonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //var febo = new List<int> {1, 1};

            //var pre1 = febo[febo.Count - 1];
            //var pre2 = febo[febo.Count - 2];

            //var count=0;

            //for (int i = 0; i <= 17; i++)
            //{
            //    count = pre1 + pre2;
            //    febo.Add(count);
            //    pre1 = febo[febo.Count - 1];
            //    pre2 = febo[febo.Count - 2];

            //}
            //Console.WriteLine(count);

            var febo = new List<int> { 1, 1 };

            while(febo.Count< 20)
            {
                var pre1 = febo[febo.Count - 1];
                var pre2 = febo[febo.Count - 2];

                febo.Add(pre1 + pre2);
            }

            Console.WriteLine(febo[febo.Count - 1]);
        }
    }
}
