using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryArea;
using System;

namespace FigureAreaTest
{
    [TestClass]
    public class AreaTest
    {
        [TestMethod]
        public void TestMethodAreaTriangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            double expected = 6;

            double result = FigureArea.Area(sideA, sideB, sideC);

            Assert.AreEqual(result, expected, string.Format("Expected for '{0}': false; Actual: {1}",
                                     expected, result));
        }

        [TestMethod]
        public void TestMethodDoesNoAreaTriangle()
        {
            double sideA = 5;
            double sideB = 5;
            double sideC = 6;

            // expected = 12
            double expected = 11;

            double result = FigureArea.Area(sideA, sideB, sideC);

            Assert.AreNotEqual(result, expected, string.Format("Expected for '{0}': false; Actual: {1}",
                                     expected, result));
        }

        [TestMethod]
        public void TestMethodRightTriangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            bool expected = true;

            bool result = FigureArea.RightTriangle(sideA, sideB, sideC);

            Assert.IsTrue(result, string.Format("Expected for '{0}': false; Actual: {1}",
                                     expected, result));
        }

        [TestMethod]
        public void TestMethodDoesNoRightTriangle()
        {
            double sideA = 5;
            double sideB = 5;
            double sideC = 6;

            // expected = false
            bool expected = true;

            bool result = FigureArea.RightTriangle(sideA, sideB, sideC);

            Assert.AreNotEqual(result, string.Format("Expected for '{0}': false; Actual: {1}",
                                     expected, result));
        }

        [TestMethod]
        public void TestMethodAreaCircle()
        {
            double radius = 2;

            double expected = 12.566370614359172;

            double result = Math.Round(FigureArea.Area(radius), 15);

            Assert.AreEqual(result, expected, string.Format("Expected for '{0}': false; Actual: {1}",
                                     expected, result));
        }

        [TestMethod]
        public void TestMethodDoesNoAreaCircle()
        {
            double radius = 3;

            // expected = 28.274333882308138;
            double expected = 11;

            double result = Math.Round(FigureArea.Area(radius), 15);

            Assert.AreNotEqual(result, expected, string.Format("Expected for '{0}': false; Actual: {1}",
                                     expected, result));
        }

    }
}
