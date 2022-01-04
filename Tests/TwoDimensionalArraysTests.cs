using NUnit.Framework;
using System;

namespace ProjTests
{
    public class TwoDimensionalArraysTests
    {

        static readonly object[] randomArr = new[] { new object[] { new int[,] { { 95, -5, 98 }, { -72, 12, 5 }, { 68, -75, 74 } }, -75} };
        [TestCaseSource("randomArr")]

        public void FindMinElement_WhenArrIsNotEmpty_ShouldReciveMinElement(int[,] arr, int expectedResult)
        {
            int actualResult = ProjLibrary.TwoDimensionalArray.FindMinElement_1(arr);
            Assert.AreEqual(actualResult, expectedResult);
        }


        static readonly object[] emptyArr = new[] { new object[] { new int[,] { } } };
        [TestCaseSource("emptyArr")]

        public void FindMinElement_WhenArrHasNoElemtnts_ShouldThrowArgumentNullException(int[,] arr)
        {
            try
            {
                ProjLibrary.TwoDimensionalArray.FindMinElement_1(arr);
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
                ProjLibrary.TwoDimensionalArray.FindMinElement_1(null);
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