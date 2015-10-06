using System;

namespace Abstraction
{
    class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Radius must be greater than zero!");
                }
            }
        }
        
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        /// Calculate surface of circle
        /// </summary>
        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
