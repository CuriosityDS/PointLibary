using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLibary
{
    public class Squar:Rectangle
    {
        Point[] points = new Point[4];
        double AB, BC, CD;
        double S, P;
        public Squar() : base() { SearchAngles(); SearchSides(); SearchSquad(); }
        public Squar(Point p1, Point p2, Point p3, Point p4) : base(p1, p2, p3, p4) { SearchAngles(); SearchSides(); SearchSquad(); }

        public override void SearchSquad()
        {
            S = CD * 4;
        }
        public override string ToString()
        {
            return $"Квадратик: {base.ToString()}";
        }
    }
}
