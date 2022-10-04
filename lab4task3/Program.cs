using System;

namespace lab4task3
{
    class Point<M>
    {
        M x;
        M y;
        public Point(M a, M b)
        {
            x = a;
            y = b;
        }
        public override string ToString()
        {
            return ("X = " + x.ToString() + " , Y = " + y.ToString());
        }
    }
    class Calculate<T>
    {
        public static void Swap(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            Calculate<int>.Swap(ref x, ref y);
            Console.WriteLine("X = {0}", x);
            Console.WriteLine("Y = {0}", y);
            Point<float> pt1 = new Point<float>(5.6f, 7.9f);
            Point<float> pt2 = new Point<float>(20.5f, 50.7f);
            Calculate<Point<float>>.Swap(ref pt1, ref pt2);
            Console.WriteLine("PT1 = {0}", pt1.ToString());
            Console.WriteLine("PT2 = {0}", pt2.ToString());
        }
    }
}
