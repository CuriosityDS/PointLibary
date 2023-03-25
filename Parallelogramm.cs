using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLibary
{
    public class Parallelogramm:Rectangle
    {
        Point[] points = new Point[4];
        double ABC, BCD, CDA, DAB;
        double AB, BC, CD, DA, AC, BD;
        double S, P;
        public Parallelogramm() : base() { SearchAngles(); SearchSides(); SearchSquad(); }
        public Parallelogramm(Point p1, Point p2, Point p3, Point p4) : base(p1, p2, p3, p4) { SearchAngles(); SearchSides(); SearchSquad(); }

        public override void SearchSquad()
        {
            S = CD * (CDA * DA);
        }
        public override string ToString()
        {
            return $"Параллелограмм: {base.ToString()}";
        }
    }
}
