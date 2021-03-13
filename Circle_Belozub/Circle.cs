using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Belozub
{
    class Circle
    {
        public readonly Point Center = new Point();

        public double Radius { get; private set; }

        public double CircleLength => 2 * Math.PI * Radius;

        public double CircleArea => Math.PI * Radius * Radius;

        public Circle()
        {

        }

        public Circle(double x, double y, double radius)
        {
            Center = new Point(x, y);
            Radius = radius;
        }

    }
}
