using System;

namespace OOPS
{
    class BaseOne
    {
        private int a, b;
        public void getdata()
        {
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
        }

        public void disp()
        {
            Console.WriteLine($"values of a and b are {a} and {b}");
        }
    }

    class BaseTwo
    {
        private int a, b;
        public void getdata()
        {
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
        }

        public void getdata(int a , int b)
        {
            this.a = a;
            this.b = b;
        }

        public void getdata(int ab)
        {
            a = b = ab;
        }

        public void getdata(BaseTwo ob)
        {
            a= ob.a;
            b= ob.b;
        }
        public void disp()
        {
            Console.WriteLine($"Values of a and b are {a} and {b}");
        }
    }

    class BaseThree
    {
        private int a, b;
        public BaseThree()
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void disp()
        {
            Console.WriteLine($"values of a and b are {a} and {b}");
        }
    }

    class BaseFour
    {
        private int a, b;
        public BaseFour()
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
        public BaseFour(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public BaseFour(int ab)
        {
            a = b = ab;
        }

        public BaseFour(BaseFour ob)
        {
            a = ob.a;
            b = ob.b;
        }
        public void disp()
        {
            Console.WriteLine($"values of a and b are {a} and {b}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //BaseOne b = new BaseOne();
            //b.getdata();
            //b.disp();


            //method overloading
            //BaseTwo b1 = new BaseTwo();
            //BaseTwo b2 = new BaseTwo();
            //BaseTwo b3 = new BaseTwo();
            //BaseTwo b4 = new BaseTwo();
            //b1.getdata();
            //b2.getdata(100,200);
            //b3.getdata(10000);
            //b4.getdata(b1);
            //b1.disp();
            //b2.disp();
            //b3.disp();
            //b4.disp();

            //constructor
            //BaseThree b1 = new BaseThree();
            //b1.disp();

            //constructor over loading
            BaseFour b1 = new BaseFour();
            BaseFour b2 = new BaseFour(100,200);
            BaseFour b3 = new BaseFour(100000);
            BaseFour b4 = new BaseFour(b1);
            b1.disp();
            b2.disp();
            b3.disp();
            b4.disp();

        }
    }
}
