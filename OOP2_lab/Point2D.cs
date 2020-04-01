using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_lab
{
    class Point2D
    {
        private double x;
        private double y;
        private double shiftX;
        private double shiftY;

        public Point2D(double x, double y)
        {
            this.x = x ;
            this.y = y ;
        }
        public double getX()
        {
            return x + shiftX;
        }
        public double getY()
        {
            return y + shiftY;
        }
        public void ShiftX(double value)
        {
            shiftX+=value;
        }

        public void ShiftY(double value)
        {
            shiftY += value;
        }
        public double getDistance(Point2D otherPoint)
        {
            return Math.Sqrt(Math.Pow(x - otherPoint.getX(), 2) + Math.Pow(y - otherPoint.getY(), 2));
        }
        public override string ToString()
        {
            return "(" + (Math.Round(x+shiftX)) + "; " + (Math.Round(y+shiftY)) + ")";
        }
    }
}
