using NUnit.Framework;
using System;

namespace ProjTests
{
    class LoopsTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(1, 5, 1)]
        [TestCase(2, 3, 8)]

        public void RiseToThePower_WhenNumAndDegreeIsNotZero_ShoultRiseToThePower(double num, int degree, double expectedResult)
        {
            double actualResult = ProjLibrary.Loops.RiseToThePower_1(num, degree);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 0)]
        [TestCase(0, 1)]
        [TestCase(1, 0)]

        public void RisetoThePower_WhenNumOrDegreeIsZero_ShoudThrowArgumentException(double num, int degree)
        {
            try
            {
                ProjLibrary.Loops.RiseToThePower_1(num, degree);

            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Don't use zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(1000, new int[] { 1000 })]
        [TestCase(99, new int[] { 99, 198, 297, 396, 495, 594, 693, 792, 891, 990 })]

        public void RoundDigits_WhenDeviderIsNotZero_ShoultRoundDigits(int devider, int[] expectedResult)
        {
            int[] actualResult = ProjLibrary.Loops.RoundDigits_2(devider);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0)]

        public void RoundDigits_WhenDeviderIsZero_ShouldThrowDivideByZeroException(int devider)
        {
            try
            {
                ProjLibrary.Loops.RoundDigits_2(devider);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Divider can't be zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(5, 2)]
        [TestCase(1025, 32)]

        public void TotalCountOfPositiveDigits_WhenNumIsGratherZero_ShouldCalculateFourmula(int maxNum, int expectedResult)
        {
            int actualResult = ProjLibrary.Loops.TotalCountOfPositiveDigits_3(maxNum);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestCase(0)]
        [TestCase(-10)]

        public void TotalCountOfPositiveDigits_WhenNumIsZeroOrLessZero_ShouldThrowArgumentException(int maxNum)
        {
            try
            {
                ProjLibrary.Loops.TotalCountOfPositiveDigits_3(maxNum);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Number should be greater than zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
