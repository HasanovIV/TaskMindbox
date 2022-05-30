using System;
using LibraryArea.Interfaces;

namespace LibraryArea.Figures
{
    class Circle: IAreaFigure
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            double result = Math.PI * Math.Pow(radius, 2);
            return result;
        }
    }
}
