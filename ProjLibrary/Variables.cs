using System;

namespace ProjLibrary
{
    public class Variables
    {
        public static double CalculateFormula_1(double A, double B)
        {
            if (A == 0 && B == 0)
            {
                throw new NullReferenceException("Both are zero");
            }
            if (A == B)
            {
                throw new ArgumentException("Divide by zero");
            }

            return (5 * A + B * B) / (B - A);
        }
        public static (string A, string B) SwapVariables_2(string _first, string _second)
        {
            if (_first == null || _second == null)
            {
                throw new ArgumentNullException("Variable/s is/are null");
            }

            (string, string) tuple = (_second, _first);
            return tuple;
        }

        public static (int resultOfDividing, int chengeFromDividing) DividingAndChange_3(int A, int B)
        {
            if (A == 0)
            {
                throw new NullReferenceException("Zero is not allowed as integer");
            }
            if (B == 0)
            {
                throw new DivideByZeroException();
            }

            (int, int) tuple = (A / B, A % B);
            return tuple;
        }

        public static double CalculateEquation_4(double A, double B, double C)
        {
            if (A == 0)
            {
                throw new DivideByZeroException();
            }
            if (C - B == 0)
            {
                throw new NullReferenceException("Zero is not allowed as integer");
            }

            return (C - B) / A;
        }

        public static (double A, double B) StraightLine_5(double X1, double Y1, double X2, double Y2)
        {
            if (X1 == X2 && Y1 == Y2)
            {
                throw new ArgumentException("Both point have the same coordinates");
            }
            if (X2 - X1 == 0)
            {
                throw new DivideByZeroException();
            }

            (double, double) tuple = ((Y2 - Y1) / (X2 - X1), (X1 * Y2 - X2 * Y1) / (X2 - X1) * -1);
            return tuple;
        }
    }
}
