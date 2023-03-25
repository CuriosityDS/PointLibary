using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLibary
{
    public class Rhomb:Rectangle
    {
        Point[] points = new Point[4];
        double ABC, BCD, CDA, DAB;
        double AB, BC, CD, DA, AC, BD;
        double S, P;
        public Rhomb() : base() { SearchAngles(); SearchSides(); SearchSquad(); }
        public Rhomb(Point p1, Point p2, Point p3, Point p4) : base(p1, p2, p3, p4) { SearchAngles(); SearchSides(); SearchSquad(); }
        public override void SearchSquad()
        {
            S = CD * ((AC * BD) / (2 * CD));
        }
        public override string ToString()
        {
            return $"Ромбик: {base.ToString()}";
        }
    }
}
