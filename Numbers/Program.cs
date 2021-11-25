using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=19;
            int b=23;
            int bb=8;
            int c=a+b;
            int d=a*b;
            int e=b/a;
            int aa=a + b * bb;
            Console.WriteLine(c+" "+d+" "+e);

            Console.WriteLine(aa);
            Console.WriteLine("Quotient "+(a+b)/bb);

            int div=(a+b)%bb;
            Console.WriteLine("Remainder "+(a+b)%bb);

            int max=int.MaxValue;
            int min=int.MinValue;
            Console.WriteLine($"the max value is {max} and min value is {min}");

            double big1 = 1.0/3.0;
            Console.WriteLine(big1);

            double max1=double.MaxValue;
            double min1=double.MinValue;
            Console.WriteLine($"The range of double is {min1} to {max1}");

            decimal maxdec=decimal.MinValue;
            decimal mindec=decimal.MaxValue;
            Console.WriteLine($"The range of decimal is {mindec} to {maxdec}");

            decimal dec= 1.0M/3.0M;
            Console.WriteLine(dec);

            long minlong=long.MinValue;
            long maxlong=long.MaxValue;
            Console.WriteLine($"The range of long is {minlong} to {maxlong}");

            short minsho=short.MinValue;
            short maxsho=short.MaxValue;
            Console.WriteLine($"The range of short is {minsho} to {maxsho}");

            //Area
            double radius=2.50;
            double area=Math.PI * radius * radius;
            Console.WriteLine(area);
        }
    }
}
