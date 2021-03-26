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
        static void Main(string[] args)
        {
            using (StreamReader fileIn = new StreamReader("input.txt", Encoding.GetEncoding(1251)))
            {
                double x = double.Parse(fileIn.ReadLine());
                double y = double.Parse(fileIn.ReadLine());
                double radius = double.Parse(fileIn.ReadLine());

                Point point = new Point(x, y);
                Circle circle = Circle.CreateCircle(point, radius);
                Console.WriteLine(circle);

                Console.WriteLine($"Длина окружности = {circle.CircleLength}, площадь круга = {circle.CircleArea}");
                Console.WriteLine();


                Point new_point = circle.Center;
                new_point.X = 12;
                point.Y = -5;

                Console.WriteLine("Первая точка с измененным положением: {0}", point);
                Console.WriteLine("Новая точка со сдвигом от центра: {0}", new_point);
                Console.WriteLine(circle.Center);

            }
        }
    }
}