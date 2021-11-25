using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "vinni", "gai", "bannu", "bharath" };
            //foreach(string name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}!");
            //}
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!!");
            }

            names.Add("chodavaram");
            names.Add("alluru");
            names.Remove("gai");
            names.Remove("bannu");

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!!!");
            }

            foreach (string name in names)
            {
                Console.WriteLine($"The index of {name} is {names.IndexOf(name)}");
            }

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name}!!!");
            }
        }
    }
}
