using System;

namespace AbstractnInterface
{
    public abstract class Shape
    {
        public abstract void draw();
    }

    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }

    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    interface Shapes
    {
        void draw();
    }

    class Rect : Shapes
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rect");
        }
    }

    class cir : Shapes
    {
        public void draw()
        {
            Console.WriteLine("Drawing cir");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract
            //Shape r = new Rectangle();
            //Shape c = new Circle();
            //r.draw();
            //c.draw();


            //Interface
            Shapes s1 = new Rect();
            s1.draw();
            Shapes s2 = new cir();
            s2.draw();
        }
    }
}
