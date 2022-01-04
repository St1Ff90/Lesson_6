using NUnit.Framework;
using System;

namespace ProjTests
{
    class ConditionsTests
    {

        [TestCase(5, 3, 8)]
        [TestCase(6, 6, 36)]
        [TestCase(6, 10, -4)]

        public void CalculateFormula_ShouldCulculateFormula(double a, double b, double expectedResult)
        {
            double actualResult = ProjLibrary.Conditions.Sum_1(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(2.1, 8.1, 1)]
        [TestCase(-3.4, -28.5, 3)]
        [TestCase(-32.3, 8.1, 2)]
        [TestCase(23.4, -7.6, 4)]

        public void PointCoordinates_WhenXOrYIsNotZero_ShpuldPointCoordinates(double x, double y, int expectedResult)
        {
            int actualResult = ProjLibrary.Conditions.PointCoordinates_2(x, y);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 0)]

        public void PointCoordinates_WhenXOrYIsZero_ShpuldThrowArgumentException(double x, double y)
        {
            try
            {
                ProjLibrary.Conditions.PointCoordinates_2(x, y);
            }

            catch (ArgumentException ex)
            {
                Assert.AreEqual("Сoordinates shouldn't be on an axis", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
