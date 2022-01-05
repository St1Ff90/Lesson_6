using NUnit.Framework;
using System;

namespace ProjTests
{
    public class TwoDimensionalArraysTests
    {

        static readonly object[] randomArr = new[] { new object[] { new int[,] { { 95, -5, 98 }, { -72, 12, 5 }, { 68, -75, 74 } }, -75 } };
        [TestCaseSource("randomArr")]
        public void FindMinElement_WhenArrIsNotEmpty_ShouldReciveMinElement(int[,] arr, int expectedResult)
        {
            int actualResult = ProjLibrary.TwoDimensionalArray.FindMinElement(arr);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void FindMinElement_WhenArrHasNoElemtnts_ShouldThrowArgumentNullException()
        {
            try
            {
                ProjLibrary.TwoDimensionalArray.FindMinElement(new int[,] { });
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is empty", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void FindMinElement_WhenArrIsNull_ShouldThrowArgumentNullException()
        {
            try
            {
                ProjLibrary.TwoDimensionalArray.FindMinElement(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is empty", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

    }
}