using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class GeometryCalculations
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }
            else if (!(a + b > c && a + c > b && b + c > a))
            {
                throw new ArgumentOutOfRangeException("Lines could not form a triangle.");
            }
            else
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                return area;
            }
        }
    }
}
