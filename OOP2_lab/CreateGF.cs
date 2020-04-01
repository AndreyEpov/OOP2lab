using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_lab
{
    class CreateGF
    {
        Random random = new Random();
        const int MAX = 50;
        // генерация координат точки
 
        public Triangle GetTriangle()
        {
            double x1 = Math.Round(random.NextDouble() * MAX);
            double x2 = Math.Round(random.NextDouble() * MAX);
            double x3 = Math.Round(random.NextDouble() * MAX);

            double y1 = Math.Round(random.NextDouble() * MAX);
            double y2 = Math.Round(random.NextDouble() * MAX);
            double y3 = Math.Round(random.NextDouble() * MAX);

            Point2D p1 = new Point2D(x1,y1);
            Point2D p2 = new Point2D(x2, y2);
            Point2D p3 = new Point2D(x3, y3);

            Triangle triangle = new Triangle(p1,p2,p3);
            return triangle;

        }

        public Rectangle GetRectangle()
        {
            double rangeA = Math.Round(random.NextDouble() * MAX);
            double rangeB = Math.Round(random.NextDouble() * MAX);
            double x1 = Math.Round(random.NextDouble() * MAX);
            double x2 = x1+rangeA;
            double x3 = x1+rangeA;
            double x4 = x1;
            double y1 = Math.Round(random.NextDouble() * MAX);
            double y2 = y1;
            double y3 = y1+rangeB;
            double y4 = y1 + rangeB;
            Point2D p1 = new Point2D(x1,y1);
            Point2D p2 = new Point2D(x2, y2);
            Point2D p3 = new Point2D(x3, y3);
            Point2D p4 = new Point2D(x4, y4);

            Rectangle rectangle = new Rectangle(p1,p2,p3,p4);
            return rectangle;
        }
        public Rectangle GetSquare()
        {
            double range = Math.Round(random.NextDouble() * MAX);
            double x1 = Math.Round(random.NextDouble() * MAX);
            double x2 = x1+range;
            double x3 = x1;
            double x4 = x1 + range;
            

            double y1 = Math.Round(random.NextDouble() * MAX);
            double y2 = y1 + range;
            double y3 = y1 + range;
            double y4 = y1 ;

            Point2D p1 = new Point2D(x1, y1);
            Point2D p2 = new Point2D(x3, y3);
            Point2D p3 = new Point2D(x2, y2);
            Point2D p4 = new Point2D(x4, y4);

            Rectangle square = new Rectangle(p1, p2, p3, p4);
            return square;
        }
    }
}
