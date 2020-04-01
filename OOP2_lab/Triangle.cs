using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_lab
{
    class Triangle
    {
        private Point2D p1;
        private Point2D p2;
        private Point2D p3;
        public Triangle(Point2D p1, Point2D p2, Point2D p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
        public Point2D getPoint1()
        {
            return p1;
        }
        public Point2D getPoint2()
        {
            return p2;
        }
        public Point2D getPoint3()
        {
            return p3;
        }

        public void ShiftX(double value)
        {
            p1.ShiftX(value);
            p2.ShiftX(value);
            p3.ShiftX(value);
        }

        public void ShiftY(double value)
        {
            p1.ShiftY(value);
            p2.ShiftY(value);
            p3.ShiftY(value);
        }
        public double getPerimetr()
        {
            return p1.getDistance(p2) + p2.getDistance(p3) + p3.getDistance(p1);
        }
        public double getArea()
        {
            double p = (p1.getDistance(p2) + p2.getDistance(p3) + p3.getDistance(p1) / 2);
            return Math.Sqrt(p * (p - p1.getDistance(p2)) * (p - p2.getDistance(p3)) * (p - p3.getDistance(p1)));
        }

    }
}
