using System;
using System.Collections.Generic;
using System.Text;

namespace ProjLibrary
{
    public class OneDimensionalArrays
    {
        public static int MinNumInArray_1(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            return arr[MinIndexInArray_3(arr)];
        }

        public static int MaxNumInArray_2(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            return arr[MaxIndexInArray_4(arr)];

        }

        public static int MinIndexInArray_3(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[result])
                {
                    result = i;
                }
            }

            return result;
        }

        public static int MaxIndexInArray_4(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[result])
                {
                    result = i;
                }
            }

            return result;
        }

        public static int SummOfItemsWithOddIndexesInArray_5(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int result = 0;

            for (int i = 1; i < arr.Length; i += 2)
            {
                result += arr[i];
            }

            return result;
        }

        public static void ReverseArray_6(ref int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                Swap(arr, i, arr.Length - i - 1);
            }
        }

        public static int OddEleemeentsCount_7(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1 || arr[i] % 2 == -1)
                {
                    result++;
                }
            }

            return result;
        }

        public static void ReverseNums_8(ref int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int integerPlus = arr.Length % 2;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                Swap(arr, i, arr.Length / 2 + i + integerPlus);
            }
        }


        public static void SelectionSortIncrease_9(ref int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                Swap(arr, i, min);
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void InsertSortDecrease_10(ref int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int x;
            int j;

            for (int i = 1; i < arr.Length; i++)
            {
                x = arr[i];
                j = i;
                while (j > 0 && arr[j - 1] < x)
                {
                    Swap(arr, j, j - 1);
                    j -= 1;
                }

                arr[j] = x;
            }
        }

        public static string[] MatchesToStringSearch(string str, string toFind)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(toFind))
            {
                throw new ArgumentException("Shouldn't be empty");
            }

            int arraySize = 0;
            int startPossition = 0;

            while (true)
            {
                if (str.IndexOf(" ", startPossition) != -1)
                {
                    string cutted = str.Substring(startPossition, str.IndexOf(" ", startPossition) - startPossition);
                    startPossition += cutted.Length + 1;
                    if (cutted.Contains(toFind))
                    {
                        arraySize++;
                    }
                }
                else
                {
                    string cutted = str.Substring(startPossition);
                    if (cutted.Contains(toFind))
                    {
                        arraySize++;
                    }
                    break;
                }
            }

            string[] result = new string[arraySize];

            int arrayPlace = 0;
            while (arrayPlace < arraySize && str.Length > 0)
            {
                if (str.Contains(" "))
                {
                    string cutted = str.Substring(0, str.IndexOf(' '));
                    str = str.Substring(cutted.Length + 1);
                    if (cutted.Contains(toFind))
                    {
                        result[arrayPlace++] = cutted;
                    }
                }
                else
                {
                    if (str.Contains(toFind))
                    {
                        result[arrayPlace] = str;
                    }
                    break;
                }
            }

            return result;
        }
    }
}
