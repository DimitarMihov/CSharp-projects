using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        private double width;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than zero!");
                }
            }
        }

        private double height;

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Height must be greater than zero!");
                }
            }
        }
        
        
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>
        /// Calculates surface of rectangle
        /// </summary>
        /// <returns></returns>
        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
