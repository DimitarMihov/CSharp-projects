using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSurfaceOfShape
{
    class Triangle : Shape
    {
        public Triangle(double width, double hight)
        {
            this.Width = width;
            this.Hight = hight;
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Hight) / 2;
        }
    }
}
