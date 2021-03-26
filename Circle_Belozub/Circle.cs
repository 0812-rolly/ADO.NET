using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Belozub
{
    class Circle
    {
        private Point center = new Point(0, 0);

        private double radius = 1;


        private Circle(Point center, double radius)
        {
            this.center = new Point(center);
            this.radius = radius;
        }

        private double Radius { get => radius; set => radius = value; }

        public Point Center { get => new Point(center); set => center = new Point(value); }

        public override string ToString()
        {
            return "Круг с радиусом = " + radius + ", центр в точке " + center;
        }

        //Calculations

        public double CircleLength
        {
            get
            {
                return Math.PI * 2 * radius;
            }
        }

        public double CircleArea
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }

        //Validation

        public static Circle CreateCircle(Point p, double r)
        {
            try
            {
                if (r > 0)
                {
                    return new Circle(p, r);
                }
                else
                {
                    throw new ArgumentException("Вы не можете ввести отрицательный радиус: " + r + "\n");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return new Circle(p, -r);
            }
        }

    }



}
