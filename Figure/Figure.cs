using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Figure
    {
        private Point[] points;
        private string name;

        public Figure(Point[] points)
        {

            name = Enum.GetName(typeof(Polygon), points.Length);
            this.points = points;
        }

        public float LengthSide(Point A, Point B)
        {
            return MathF.Sqrt(MathF.Pow(B.X - A.X, 2) + MathF.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            float perim = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perim += LengthSide(points[i], points[i + 1]);
            }

            perim += LengthSide(points[points.Length - 1], points[0]);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Perimetr: {perim}");
        }
    }
}