using System;
using LibraryArea.Interfaces;

namespace LibraryArea.Figures
{
    public class Triangle: IAreaFigure
    {
        public double sideA;
        public double sideB;
        public double sideC;

        public Triangle()
        {
            sideA = 0;
            sideB = 0;
            sideC = 0;
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double Area()
        {
            double result = 0;
            double semiPerimetr = Perimeter() / 2;
            double multiply = semiPerimetr;

            multiply *= (semiPerimetr - sideA)* (semiPerimetr - sideB)* (semiPerimetr - sideC);

            result = Math.Sqrt(multiply);

            return result;
        }
        public double Perimeter()
        {
            double result = sideA + sideB + sideC;
            
            return result;
        }
    }

}
