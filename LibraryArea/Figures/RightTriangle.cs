using System;

namespace LibraryArea.Figures
{
    public class RightTriangle : Triangle
    {

        public RightTriangle(double legA, double legB, double hypotenuse)
        {
            this.sideA = legA;
            this.sideB = legB;
            this.sideC = hypotenuse;
        }

        public new double Area()
        {
            double result = (sideA * sideB) / 2;

            return result;
        }
        
        /// <summary>
        /// Функция проверяет, является ли трегольник прямоугольным.
        /// </summary>
        /// <param name="sideA">Сторона треугольника</param>
        /// <param name="sideB">Сторона треугольника</param>
        /// <param name="sideC">Сторона треугольника</param>
        /// <returns></returns>
        public static bool IsRightTriangle(double sideA, double sideB, double sideC)
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

    }
}
