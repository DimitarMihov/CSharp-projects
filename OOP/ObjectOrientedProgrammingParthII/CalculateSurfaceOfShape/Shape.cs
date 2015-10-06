using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSurfaceOfShape
{
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Hight { get; set; }

        public abstract double CalculateSurface();
    }
}
