using System;

namespace hola_mundo
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Color color = new Color(22, 33, 44);
            Color blanco = Color.WHITE;
            Console.WriteLine($"{color.red}-{color.green}-{color.blue}");


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

    internal class Color
    {
        public double red { get; }
        public double green { get; }
        public double blue { get; }

        public static readonly Color WHITE = new Color(255, 255, 255);
        public static readonly Color BLACK = new Color(0, 0, 0);

        public Color(double red, double green, double blue )
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

    }
}
