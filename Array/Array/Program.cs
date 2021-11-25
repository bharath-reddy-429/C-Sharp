using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static array
            //int[] a = new int[5];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (int i in a)
            //{
            //    Console.Write(i + " ");
            //}


            //dynamic array
            Console.WriteLine("Enter Length of array :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}
