using System;

namespace LibraryArea
{
    public static class FigureArea
    {

        #region Calculate Area

        /// <summary>
        /// Функция вычисляет площади фигуры (круг, треугольник)
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
                    result = AreaCircle(sides[0]);
                    break;
                // Площадь треугольника по формуле Герона S = sqrt(p*(p-a)*(p-b)*(p-c))
                case 3:
                    result = AreaTriangle(sides);
                    break;
                default:
                    break;
            }

            return result;
        }

        private static double AreaCircle(double radius)
        {
            double result = Math.PI * Math.Pow(radius, 2);
            return result;
        }

        private static double AreaTriangle(params double[] sides)
        {
            double result = 0;
            double semiPerimetr = Perimeter(sides) / 2;
            double multiply = semiPerimetr;

            foreach (double side in sides)
                multiply *= (semiPerimetr - side);

            result = Math.Sqrt(multiply);

            return result;
        }

        private static double Perimeter(params double[] sides)
        {
            double result = 0;
            foreach (double side in sides)
            {
                result += side;
            }

            return result;
        }

        #endregion

        #region Calculate Right Triangle

        /// <summary>
        /// Функция проверяет, является ли трегольник прямоугольным.
        /// </summary>
        /// <param name="sideA">Сторона треугольника</param>
        /// <param name="sideB">Сторона треугольника</param>
        /// <param name="sideC">Сторона треугольника</param>
        /// <returns></returns>
        public static bool RightTriangle(double sideA, double sideB, double sideC)
        {
            bool result = PythagoreanTheorem(sideA, sideB, sideC) ||
                PythagoreanTheorem(sideC, sideA, sideB) ||
                PythagoreanTheorem(sideB, sideC, sideA);

            return result;
        }

        private static bool PythagoreanTheorem(double sideA, double sideB, double sideC)
        {
            bool result = Math.Pow(sideC, 2) == (Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return result;
        }

        #endregion

    }
}
