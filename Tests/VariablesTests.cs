using NUnit.Framework;
using System;

namespace ProjTests
{
    public class VariablesTests
    {
        [TestCase(2, 3, 19)]
        [TestCase(3, 5, 20)]
        public void CalculateFormula_WhenANotEquualToB_ShouldCulculateFormula(double a, double b, double expeectedResult)
        {
            double actualResult = ProjLibrary.Variables.CalculateFormula_1(a, b);
            Assert.AreEqual(expeectedResult, actualResult);
        }

        [TestCase(1, 1)]
        public void CalculateFormula_WhenAEquualToB_ShouldThrowArgumentException(double a, double b)
        {
            try
            {
                ProjLibrary.Variables.CalculateFormula_1(a, b);
            }

            catch (ArgumentException ex)
            {
                Assert.AreEqual("Divide by zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(0, 0)]
        public void CalculateFormula_WhenAAndBIsZero_ShouldThrowNullReferenceException(double a, double b)
        {
            try
            {
                ProjLibrary.Variables.CalculateFormula_1(a, b);

            }

            catch (NullReferenceException ex)
            {
                Assert.AreEqual("Both are zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase("first", "second")]
        [TestCase("Hello world!", "World hello!")]
        public void SwapVariables_WhenFirstOrSecondIsNotNullOrBothAreNull_ShouldSwapVariables(string first, string second)
        {
            (string first, string second) tuple = ProjLibrary.Variables.SwapVariables_2(first, second);
            Assert.AreEqual(tuple.first, second);
            Assert.AreEqual(tuple.second, first);
        }

        [TestCase(null, null)]
        [TestCase(null, "")]
        [TestCase("", null)]
        public void SwapVariables_WhenFirstOrSecondIsNullOrBothAreNull_ShouldThrowArgumentNullException(string first, string second)
        {
            try
            {
                ProjLibrary.Variables.SwapVariables_2(first, second);
            }

            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Variable/s is/are null", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}