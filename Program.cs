using System;

namespace hola_mundo
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Point p = new Point(2, 3);
            Point p2 = new Point(-4, 0);
            Console.WriteLine($"({p.X}, {p.Y})");
            Console.WriteLine($"({p2.X}, {p2.Y})");


        }


    }

    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point() : this(0, 0) { }

    }
}
