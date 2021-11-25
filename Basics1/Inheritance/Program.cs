using System;

namespace Inheritance
{
    class BaseOne
    {
        protected int a, b;
        public void getdata()
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
    }

    class DerivedOne : BaseOne
    {
        public void disp()
        {
            Console.WriteLine($"values of a and b are {a} and {b}");
        }
    }

    class DerivedTwo : DerivedOne
    {
        public void Add()
        {
            Console.WriteLine($"Addition of a and b is {a + b}");
        }
    }

    class BaseTwo
    {
        public void disp()
        {
            Console.WriteLine("This is in Base class");
        }
    }

    class Derived : BaseTwo
    {
        public void disp()
        {
            base.disp();
            Console.WriteLine("This is in derived class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Single Inheritance
            //DerivedOne d1 = new DerivedOne();
            //d1.getdata();
            //d1.disp();

            //Multilevel inheritance
            //DerivedTwo d1 = new DerivedTwo();
            //d1.getdata();
            //d1.disp();
            //d1.Add();

            //Over Riding
            Derived d = new Derived();
            d.disp();
        }
    }
}
