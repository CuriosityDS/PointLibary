using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLibary
{
    public class Rectangle : Point
    {
        Point[] point = new Point[4];
        double ABC, BCD, CDA, DAB;
        double AB, BC, CD, DA, AC, BD;
        double S, P;
        Random random = new Random();
        public Rectangle()
        {
            for (int i = 0; i < point.Length; i++)
            {
                point[i] = new Point(random.Next(15), random.Next(15));
            }
            SearchAngles();
            SearchSides();
            SearchSquad();
            SearchDiagonals();
        }
        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            SearchAngles();
            SearchSides();
            SearchSquad();
            SearchDiagonals();
        }

        public double Angles(Point a, Point b, Point c)
        {
            Point AB = new Point(a.x - b.x, a.y - b.y);
            Point AC = new Point(a.x - b.x, a.y - b.y);
            double Angle = (AB * AC) / (Math.Abs(AB.x * AB.x + AB.y * AB.y) * Math.Abs(AC.x * AC.x + AC.y * AC.y));
            return Angle;
        }
        public virtual void SearchAngles()
        {
            ABC = Angles(point[0], point[1], point[2]);
            BCD = Angles(point[1], point[2], point[3]);
            CDA = Angles(point[2], point[3], point[0]);
            DAB = Angles(point[3], point[0], point[1]);
        }

        public void SearchSides()
        {
            AB = Math.Sqrt((point[1].x - point[0].x) * (point[1].x - point[0].x) + (point[1].y - point[0].y) * (point[1].y - point[0].y));
            BC = Math.Sqrt((point[2].x - point[1].x) * (point[2].x - point[1].x) + (point[2].y - point[1].y) * (point[2].y - point[1].y));
            CD = Math.Sqrt((point[3].x - point[2].x) * (point[3].x - point[2].x) + (point[3].y - point[2].y) * (point[3].y - point[2].y));
            DA = Math.Sqrt((point[0].x - point[3].x) * (point[0].x - point[3].x) + (point[0].y - point[3].y) * (point[0].y - point[3].y));
        }
        public virtual void SearchSquad()
        {
            SearchPerimetr();
            double pp = P / 2;
            S = Math.Sqrt((pp - AB) * (pp - BC) * (pp - CD) * (pp - DA));
        }
        public void SearchPerimetr()
        {
            double P = AB + BC + CD + DA;
        }

        public void SearchDiagonals()
        {
            AC = Math.Sqrt((point[2].x - point[0].x) * (point[2].x - point[0].x) + (point[2].y - point[0].y) * (point[2].y - point[0].y));
            BD = Math.Sqrt((point[3].x - point[1].x) * (point[3].x - point[1].x) + (point[3].y - point[1].y) * (point[3].y - point[1].y));
        }
        public override string ToString()
        {
            return $"\nПлощадь: [{S}]\nПериметр: [{AB + BC + CD + DA}]\nСтороны: [AB={AB}, BC={BC}, CD={CD}, DA={DA}]\nДиагонали: [{AC}, {BD}]\nУглы: [ABC={ABC}, BCD={BCD}, CDA={CDA}, DAB={DAB}]";
        }
        public override bool Equals(object tochka)
        {
            Rectangle temp = (Rectangle)tochka;
            if (this.S == temp.S)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

}


