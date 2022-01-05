using System;
using System.Collections.Generic;
using System.Text;

namespace ProjLibrary
{
    public class Loops
    {
        public static double RiseToThePower(double num, int degree)
        {
            if (num == 0 || degree == 0)
            {
                throw new ArgumentException("Don't use zero");
            }

            double result = 1;
            for (int i = 1; i <= degree; i++)
            {
                result *= num;
            }

            return Math.Round(result, 2);
        }

        public static int[] RoundDigits(int divider)
        {
            if (divider == 0)
            {
                throw new DivideByZeroException("Divider can't be zero");
            }

            int[] result = new int[1000 / divider];
            int pointer = 0;
            for (int i = divider; i <= 1000; i += divider)
            {
                result[pointer++] = i;
            }

            return result;
        }

        public static int TotalCountOfPositiveDigits(int maxNum)
        {
            if (maxNum < 1)
            {
                throw new ArgumentException("Number should be greater than zero");
            }

            int result = 0;
            for (int i = 1; i <= maxNum; i++)
            {
                if (i * i < maxNum)
                {
                    ++result;
                }
            }

            return result;
        }

        public static int Divider(int num)
        {
            if (num < 1)
            {
                throw new ArgumentException("Number should be greater than zero");
            }

            int result = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    result = i;
                }
            }

            return result;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int SumOfDigitsDividedtoSeven(int start, int end)
        {
            if (start == end)
            {
                throw new ArgumentException("Numbers are the same");
            }

            int result = 0;

            if (end < start)
            {
                Swap(ref start, ref end);
            }

            start += (7 - start % 7) % 7;
            for (int i = start; i <= end; i += 7)
            {
                result += i;
            }

            return result;
        }

        public static int FibonacciLineToStep(int count)
        {
            if (count < 1)
            {
                throw new ArgumentException("Number should be greater than zero");
            }

            int result = 0;
            int currentNum = 1;
            int previousNum = 1;

            for (int i = 0; i < count - 2; i++)
            {
                result = currentNum + previousNum;
                previousNum = currentNum;
                currentNum = result;
            }

            return result;
        }

        public static int EuclideAlgorithm(int first, int second)
        {
            if (first < 1 || second < 1)
            {
                throw new ArgumentException("Number should be greater than zero");
            }
            while (first != 0 && second != 0)
            {
                if (first > second)
                {
                    first -= second;
                }
                else
                {
                    second -= first;
                }
            }

            return first + second;
        }


        public static double DigitSqareByBisection(int num)
        {
            if (num < 1)
            {
                throw new ArgumentException("Number should be greater than zero");
            }
            if (Math.Pow(num, 1.0 / 3.0) % 1 != 0)
            {
                throw new ArgumentException("Number should be Sqare of Integer");
            }


            double left = 0;
            double right = num;
            double result = 0;

            while (right - left > 1.0)
            {
                double middle = (right - left) / 2;
                result = left + middle;
                if (middle * middle * middle < num)
                {
                    left = middle;
                }
                else
                {
                    right = middle;
                }
            }

            return result;
        }


        public static int CountOddNumbers(int num)
        {
            if (num < 1)
            {
                throw new ArgumentException("Number should be greater than zero");
            }

            int result = 0;

            do
            {
                if (num % 2 == 0)
                {
                    ++result;
                }

                num /= 10;
            } while (num != 0);

            return result;
        }

        public static int ReverseNum(int num)
        {
            if (num == 0)
            {
                throw new ArgumentException("Num shouldn't be zero");
            }

            int result = 0;

            while (num > 0)
            {
                result *= 10;
                result += num % 10;
                num /= 10;
            }

            return result;
        }

        public static int[] NumsWithSumOfEvenBiggerOdd(int num)
        {
            if (num < 1)
            {
                throw new ArgumentException("Number should be greater than zero");
            }

            int[] result = new int[num / 2];
            int fullNumber = 0;
            int arrayPointer = 0;

            for (int i = 1; i <= num; i++)
            {
                fullNumber = fullNumber * 10 + i;
            }

            for (int i = 0; i < num / 2; i++)
            {
                if (fullNumber % 10 % 2 == 0)
                {
                    result[arrayPointer] = fullNumber;
                    ++arrayPointer;
                }
                fullNumber /= 10;
            }

            return result;
        }

        public static bool SameDigits(int first, int second)
        {
            if (first < 1 || second < 1)
            {
                throw new ArgumentException("Numbers should be greater than zero");
            }

            while (first > 0)
            {
                int digitFromFirst = first % 10;
                first /= 10;
                int secondCopy = second;
                while (secondCopy > 0)
                {
                    if (secondCopy % 10 == digitFromFirst)
                    {
                        return true;
                    }

                    secondCopy /= 10;
                }
            }

            return false;
        }
    }
}
