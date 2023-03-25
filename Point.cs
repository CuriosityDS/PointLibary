using System;

namespace PointLibary
{
    public class Point : IComparable
    {
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double x
        {
            get;
            set;
        }
        public double y
        {
            get;
            set;
        }
        public static double operator *(Point MultiplicationA, Point MultiplicationB)
        => MultiplicationA.x * MultiplicationB.x + MultiplicationA.y * MultiplicationB.y;
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
