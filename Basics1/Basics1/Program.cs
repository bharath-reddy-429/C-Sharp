using System;

namespace Basics1
{
     class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //double d = double.MaxValue;
            //char c = 'a';
            //Console.WriteLine($"int is {a} and double is {d}");
            //Console.WriteLine($"{c}");

            //Conditional();
            //SwitchCase();
            //loop1();
            //loop2();
            //loop3();
            //breaking();
            //cont();
            //gotofun();

            Program p = new Program();
            //p.funshow();


            //Console.WriteLine(p.funparartn("Bharath"));
            //int val = 10;
            //Console.WriteLine("value before callbyvalue "+val);
            //p.callbyvalue(val);
            //Console.WriteLine("value after callbyvalue "+val);
            //val = 5;
            //Console.WriteLine("value before callby ref "+val);
            //p.callbyref(ref val);
            //Console.WriteLine("value after callbyef "+val);
            //int a = 10, b = 20;
            //Console.WriteLine($"values of a and b before callbyout {a} and {b}");
            //p.callbyout(out a, out b);
            //Console.WriteLine($"values of a and b after callbyout {a} and {b}");


            //arraysOne();
            //arraysTwo();
            //array2d();
        }

        private static void array2d()
        {
            Console.WriteLine("Enter number of rows and columns :");
            int a, b;
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[a, b];
            for (int i = 0;i< a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }

        }

        private static void arraysTwo()
        {
            Console.WriteLine("Enter length of array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a= new int[n];
            for(int i = 0; i < a.Length; i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            //foreach(int i in a)
            //{
            //    Console.Write(i + " ");
            //}
            int c = 0;
            foreach (int i in a)
            {
                c = c + i;
            }
            Console.WriteLine("Total of array elements "+c);


        }

        private static void arraysOne()
        {
            int[] a = { 3, 2, 6, 8, 5, 3, 7, 9, 5, 3, 45, 5 };
            foreach(int i in a)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Array.Sort(a);
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Reverse(a);
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
        }

        private void callbyvalue(int val)
        {
            val *= val;
            Console.WriteLine("value inside callbyvalue "+val);
        }
        public void callbyref(ref int val)
        {
            val *= val;
            Console.WriteLine("value inside callby ref " + val);
        }
        public void callbyout(out int a, out int b)
        {
            a=5;
            b=10;
            a *= a;
            b *= b;
            Console.WriteLine($"values of a and b inside call by out {a} and {b}");
        }
        private String funparartn(String s)
        {
            return "Hii" + s;
        }

        private void funshow()
        {
            Console.WriteLine("This is show function which is non static");
        }


        private static void gotofun()
        {
            Console.WriteLine("Enter your age");
            int a = Convert.ToInt32(Console.ReadLine());

            Eligible:
            {
                Console.WriteLine("You are Eligible");
                Console.WriteLine("Enter your age");
                a = Convert.ToInt32(Console.ReadLine());
            }

            if (a > 18)
            {
                goto Eligible;
            }
            else
            {
                Console.WriteLine("In eligible");
            }
        }

        private static void cont()
        {
            int a = 10;
            for (int i = 0; i<a; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }
        }

        private static void breaking()
        {
            int a = 10;
            for(int i = 0; i < a; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }
        }

        private static void loop3()
        {
            int a = 10, i = 0;
            do
            {
                Console.Write(i+ " ");
                i++;
            } while (i < a);
        }

        private static void loop2()
        {
            int a = 10, i = 0;
            while (i < a)
            {
                Console.Write(i+" ");
                i++;
            }
        }

        private static void loop1()
        {
            int a = 10;
            for (int i = 0; i<a; i++)
            {
                Console.Write(i + " ");
            }
        }

        public static void SwitchCase()
        {
            int a = 3;
            switch (a)
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("hii");
                    break;
                case 3:
                    Console.WriteLine("hello hii");
                    break ;
                default:
                    Console.WriteLine("Nothing");
                    break;
            }
        }

        public static void Conditional() 
        {
            int a = 10;
            int b = 20;
            int c = 30;

            if (a > b && a > c)
                Console.WriteLine("A is bigger");
            else if (b > c)
                Console.WriteLine("B is bigger");
            else
                Console.WriteLine("C is bigger");
        }
    }

}
