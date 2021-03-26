using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Belozub
{
    class Point
    {
        private double x;
        private double y;

        public Point()
        {
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "Место расположения: (" + x + ", " + y + ")";
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Point(Point point)
        {
            this.x = point.X;
            this.y = point.Y;
        }
    }
}
