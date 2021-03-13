using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Circle_Belozub
{
    class Program
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

        static void Main(string[] args)
        {
            Circle circle = new Circle();
            string inp = "C:/Users/Алексей/source/repos/Circle_Belozub/Circle_Belozub/bin/input.txt";
            string[] line = File.ReadAllLines(inp);

            try
            {
                for (int i = 0; i < line.Length; i++)
                {
                    circle = new Circle(x: double.Parse(line[0]), y: double.Parse(line[1]), radius: double.Parse(line[2]));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            if (line.Length != 3)
            {
                throw new ArgumentException("Ошибка. В файле должно содержаться 3 переменных.");
            }

                //interpolation

            Console.WriteLine($"Центр = {circle.Center.x}, {circle.Center.y}; Радиус = {circle.Radius}\n\n"
           + $"Длина окружности = {circle.CircleLength}, Площадь круга = {circle.CircleArea}");
            Console.WriteLine();
        }
    }
}