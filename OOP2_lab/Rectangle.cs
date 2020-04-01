using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_lab
{
    class Rectangle
    {
        private Point2D p1;
        private Point2D p2;
        private Point2D p3;
        private Point2D p4;
        public Rectangle(Point2D p1, Point2D p2, Point2D p3, Point2D p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
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
        public Point2D getPoint4()
        {
            return p4;
        }
        public void ShiftX(double value)
        {
            p1.ShiftX(value);
            p2.ShiftX(value);
            p3.ShiftX(value);
            p4.ShiftX(value);
        }

        public void ShiftY(double value)
        {
            p1.ShiftY(value);
            p2.ShiftY(value);
            p3.ShiftY(value);
            p4.ShiftY(value);
        }
        public double getPerimetr()
        {
            return (p1.getDistance(p2) + p2.getDistance(p3))*2;
        }
        public double getArea()
        {
            return (p1.getDistance(p2)* p2.getDistance(p3));
        }

    }
}
