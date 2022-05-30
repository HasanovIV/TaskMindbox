using System;
using LibraryArea.Figures;

namespace LibraryArea
{
    public static class FigureArea
    {

        /// <summary>
        /// Функция вычисляет площади фигуры(круг, треугольник)
        /// </summary>
        /// <param name="sides">Стороны фигуры</param>
        /// <returns></returns> 
        public static double Area(params double[] sides)
        {
            double result = 0;
            switch (sides.Length)
            {
                // Площадь круга по радиусу
                case 1:
                    Circle circle = new Circle(sides[0]);
                    result = circle.Area();
                    break;
                // Площадь треугольника по формуле Герона S = sqrt(p*(p-a)*(p-b)*(p-c))
                case 3:
                    Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);
                    result = triangle.Area();
                    break;
                default:
                    break;
            }

            return result;
        }

    }
}
