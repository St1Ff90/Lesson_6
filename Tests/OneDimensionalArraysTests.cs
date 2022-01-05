using NUnit.Framework;
using System;

namespace ProjTests
{
    public class OneDimensionalArraysTests
    {
        private static readonly object[] arr = new[] { new object[] { new int[] { 5, 54, -9, 1, 0, -19, 6 }, -19 } };
        [TestCaseSource("arr")]
        [TestCase(new int[] { 1 }, 1)]

        public void GetMinNumInArray_WhenArrIsNotNull_ShouldReturnMinNumInArr(int[] arr, int expeectedResult)
        {
            int actualResult = ProjLibrary.OneDimensionalArrays.MinNumInArray(arr);
            Assert.AreEqual(expeectedResult, actualResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void GetMinNumInArray_WhenArrIsNull_ShouldThrowArgumentNullException(int[] arr)
        {
            try
            {
                ProjLibrary.OneDimensionalArrays.MinNumInArray(arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 5, 54, -9, 1, 0, -19, 6 }, 54)]
        [TestCase(new int[] { 1 }, 1)]
        public void GetMaxNumInArra_WhenArrIsNotNull_ShouldReturnMinNumInArr(int[] arr, int expeectedResult)
        {
            int actualResult = ProjLibrary.OneDimensionalArrays.MaxNumInArray(arr);
            Assert.AreEqual(expeectedResult, actualResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void GetMaxNumInArray_WhenArrIsNull_ShouldThrowArgumentNullException(int[] arr)
        {
            try
            {
                ProjLibrary.OneDimensionalArrays.MaxNumInArray(arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 5, 54, -9, 1, 0, -19, 6 }, 5)]
        [TestCase(new int[] { 1 }, 0)]
        public void GetMinIndexInArray_WhenArrIsNotNull_ShouldReturnMinNumInArr(int[] arr, int expeectedResult)
        {
            int actualResult = ProjLibrary.OneDimensionalArrays.MinIndexInArray(arr);
            Assert.AreEqual(expeectedResult, actualResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]

        public void GetMinIndexInArray_WhenArrIsNull_ShouldThrowArgumentNullException(int[] arr)
        {
            try
            {
                ProjLibrary.OneDimensionalArrays.MinIndexInArray(arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array", ex.ParamName);          
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 5, 54, -9, 1, 0, -19, 6 }, 1)]
        [TestCase(new int[] { 1 }, 0)]
        public void GetMaxIndexInArray_WhenArrIsNotNull_ShouldReturnMinNumInArr(int[] arr, int expeectedResult)
        {
            int actualResult = ProjLibrary.OneDimensionalArrays.MaxIndexInArray(arr);
            Assert.AreEqual(expeectedResult, actualResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void GetMaxIndexInArray_WhenArrIsNull_ShouldThrowArgumentNullException(int[] arr)
        {
            try
            {
                ProjLibrary.OneDimensionalArrays.MaxIndexInArray(arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 5, 54, -9, 1, 0, -19, 6 }, 36)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6 }, 9)]
        [TestCase(new int[] { 1 }, 0)]
        public void SummOfItemsWithOddIndexesInArray_WhenArrIsNotNull_ShouldCalculate(int[] arr, int expeectedResult)
        {
            int actualResult = ProjLibrary.OneDimensionalArrays.SummOfItemsWithOddIndexesInArray(arr);
            Assert.AreEqual(expeectedResult, actualResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void SummOfItemsWithOddIndexesInArray_WhenArrIsNull_ShouldThrowArgumentNullException(int[] arr)
        {
            try
            {
                ProjLibrary.OneDimensionalArrays.SummOfItemsWithOddIndexesInArray(arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 5, 54, -9, 1, 0, -19, 6 }, new int[] { 6, -19, 0, 1, -9, 54, 5 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void ReverseArray_WhenArrIsNotNull_ShouldReverseArray(int[] arr, int[] expeectedResult)
        {
            ProjLibrary.OneDimensionalArrays.ReverseArray(ref arr);
            Assert.AreEqual(expeectedResult, arr);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void ReverseArray_WhenArrIsNull_ShouldThrowArgumentNullException(int[] arr)
        {
            try
            {
                ProjLibrary.OneDimensionalArrays.ReverseArray(ref arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 5, 54, -9, 1, 0, -19, 6 }, 4)]
        [TestCase(new int[] { 0 }, 0)]
        public void OddEleemeentsCount_WhenArrIsNotNull_ShouldCountOddEleemeents(int[] arr, int expeectedResult)
        {
            int actualResult = ProjLibrary.OneDimensionalArrays.OddEleemeentsCount(arr);
            Assert.AreEqual(expeectedResult, actualResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void OddEleemeentsCount_WhenArrIsNull_ShouldThrowArgumentNullException(int[] arr)
        {
            try
            {
                ProjLibrary.OneDimensionalArrays.OddEleemeentsCount(arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 5, 54, -9, 1, 0, -19, 6 }, new int[] { 0, -19, 6, 1, 5, 54, -9 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void ReverseNums_WhenArrIsNotNull_ShouldReverseNums(int[] arr, int[] expeectedResult)
        {
            ProjLibrary.OneDimensionalArrays.ReverseNums(ref arr);
            Assert.AreEqual(expeectedResult, arr);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void ReverseNums_WhenArrIsNull_ShouldThrowArgumentNullException(int[] arr)
        {
            try
            {
                ProjLibrary.OneDimensionalArrays.ReverseNums(ref arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 5, 54, -9, 1, 0, -19, 6 }, new int[] { -19, -9, 0, 1, 5, 6, 54 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void SelectionSortIncrease_WhenArrIsNotNull_ShouldSorrtByImcrease(int[] arr, int[] expeectedResult)
        {
            ProjLibrary.OneDimensionalArrays.SelectionSortIncrease(ref arr);
            Assert.AreEqual(expeectedResult, arr);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void SelectionSortIncrease_WhenArrIsNull_ShouldThrowArgumentNullException(int[] arr)
        {
            try
            {
                ProjLibrary.OneDimensionalArrays.SelectionSortIncrease(ref arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 5, 54, -9, 1, 0, -19, 6 }, new int[] { 54, 6, 5, 1, 0, -9, -19 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void InsertSortDecrease_WhenArrIsNotNull_ShouldSorrtByDecrease(int[] arr, int[] expeectedResult)
        {
            ProjLibrary.OneDimensionalArrays.InsertSortDecrease(ref arr);
            Assert.AreEqual(expeectedResult, arr);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void InsertSortDecrease_WhenArrIsNull_ShouldThrowArgumentNullException(int[] arr)
        {
            try
            {
                ProjLibrary.OneDimensionalArrays.InsertSortDecrease(ref arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}