using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSurfaceOfShape
{
    class Circle : Shape
    {
        public Circle(double width)
        {
            this.Width = width;
            this.Hight = width;
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Width * Math.PI;
        }
    }
}
