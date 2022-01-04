using System;
using System.Collections.Generic;
using System.Text;

namespace ProjLibrary
{
    public class TwoDimensionalArray
    {
        public static int FindMinElement_1(int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            return arr[FindMinIndex_3(arr).i, FindMinIndex_3(arr).j]; ;
        }

        public static int FindMaxElement_2(int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            
            return arr[FindMaxIndex_4(arr).i, FindMaxIndex_4(arr).j];
        }

        public static (int i, int j) FindMinIndex_3(int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
           
            (int i, int j) result = (0, 0);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[result.i, result.j] > arr[i, j])
                    {
                        result.i = i;
                        result.j = j;
                    }
                }
            }

            return result;
        }

        public static (int i, int j) FindMaxIndex_4(int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
           
            (int i, int j) result = (0, 0);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[result.i, result.j] < arr[i, j])
                    {
                        result.i = i;
                        result.j = j;
                    }
                }
            }

            return result;
        }

        public static int CompaneNeighbors_5(int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            
            int result = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i > 0 && arr[i, j] < arr[i - 1, j])
                    {
                        continue;
                    }
                    if (i < arr.GetLength(0) - 1 && arr[i, j] < arr[i + 1, j])
                    {
                        continue;
                    }
                    if (j > 0 && arr[i, j] < arr[i, j - 1])
                    {
                        continue;
                    }
                    if (j < arr.GetLength(1) - 1 && arr[i, j] < arr[i, j + 1])
                    {
                        continue;
                    }

                    result++;
                }
            }

            return result;
        }

        private static void Swap(int[,] array, int i, int j)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }

        public static void MirrorArray_6(ref int[,] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j > i)
                    {
                        Swap(arr, i, j);
                    }
                }
            }
        }
    }
}
