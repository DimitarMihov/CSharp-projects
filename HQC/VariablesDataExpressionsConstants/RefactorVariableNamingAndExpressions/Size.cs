namespace RefactorVariableNamingAndExpressions
{
    using System;
    
    public class Size
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Size GetRotatedSize(double angle)
        {
            double sizeWidth = Math.Abs(Math.Cos(angle)) * this.Width + Math.Abs(Math.Sin(angle)) * this.Height;
            double sizeHeight = Math.Abs(Math.Sin(angle)) * this.Width + Math.Abs(Math.Cos(angle)) * this.Height;
            Size sizeRotated = new Size(sizeWidth, sizeHeight);
            return sizeRotated;
        }

        public override string ToString()
        {
            string sizeToString = "Width: " + this.Width + ", Height: " + this.Height;
            return sizeToString;
        }
    }

}
