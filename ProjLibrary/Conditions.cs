using System;
using System.Collections.Generic;
using System.Text;

namespace ProjLibrary
{
    public class Conditions
    {
        public static double Sum_1(double A, double B)
        {
            double result;

            if (A > B)
            {
                result = A + B;
            }
            else if (A == B)
            {
                result = A * B;
            }
            else
            {
                result = A - B;
            }

            return result;
        }

        public static int PointCoordinates_2(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                throw new ArgumentException("Сoordinates shouldn't be on an axis");
            }

            switch (true)
            {
                case true when x < 0 && y < 0:
                    return 3;
                case true when x < 0 && y > 0:
                    return 2;
                case true when x > 0 && y < 0:
                    return 4;
                case true when x > 0 && y > 0:
                    return 1;
                default:
                    return 0;
            }
        }

        public static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public static void SortThreeDigits_3(ref double first, ref double second, ref double third)
        {
            if (first > second)
            {
                Swap(ref first, ref second);
            }
            if (second > third)
            {
                Swap(ref second, ref third);
            }
            if (first > second)
            {
                Swap(ref first, ref second);
            }
        }

        public static (double x1, double x2) QuadraticEquation_4(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("Var A shold not be zero");
            }

            double x1, x2;
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return (0, 0);
            }

            if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }

            return (x1, x2);
        }

        public static string WriteNumber_5(int num)
        {
            if (num < 10 || num > 99)
            {
                throw new ArgumentOutOfRangeException("Range out of range from 10 to 99");
            }

            string result = null;

            if (num >= 20)
            {
                switch (num / 10)
                {
                    case 2:
                        result = "twenty ";
                        break;
                    case 3:
                        result = "twenty ";
                        break;
                    case 4:
                        result = "forty ";
                        break;
                    case 5:
                        result = "fifty ";
                        break;
                    case 6:
                        result = "sixty ";
                        break;
                    case 7:
                        result = "seventy ";
                        break;
                    case 8:
                        result = "eighty ";
                        break;
                    case 9:
                        result = "ninety ";
                        break;
                }

                switch (num % 10)
                {
                    case 0:
                        result += string.Empty;
                        break;
                    case 1:
                        result += "one";
                        break;
                    case 2:
                        result += "two";
                        break;
                    case 3:
                        result += "three";
                        break;
                    case 4:
                        result += "four";
                        break;
                    case 5:
                        result += "five";
                        break;
                    case 6:
                        result += "six";
                        break;
                    case 7:
                        result += "seven";
                        break;
                    case 8:
                        result += "eight";
                        break;
                    case 9:
                        result += "nine";
                        break;
                }
            }

            else if (num < 20)
            {
                switch (num)
                {
                    case 10:
                        result = "ten";
                        break;
                    case 11:
                        result = "eleven";
                        break;
                    case 12:
                        result = "twelve";
                        break;
                    case 13:
                        result = "thirteen";
                        break;
                    case 14:
                        result = "fourteen";
                        break;
                    case 15:
                        result = "fifteen";
                        break;
                    case 16:
                        result = "sixteen";
                        break;
                    case 17:
                        result = "seventeen";
                        break;
                    case 18:
                        result = "eighteen";
                        break;
                    case 19:
                        result = "nineteen";
                        break;
                    default:
                        result = "Error!";
                        break;
                }
            }
            else
            {
                result = "Error!";
            }

            return result;
        }
    }
}
