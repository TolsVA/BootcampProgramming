using System;
namespace Algorithms;

public static class ArrayMath
{
    public static int BedGetSum(this int[] array, int n = 3)
    {
        int max = 0;
        int size = array.Length;

        for (int i = 0; i <= size - n; i++)
        {
            int t = 0;
            for (int j = i; j < i + n; j++)
            {
                t += array[j];
            }
            if (t > max) max = t;
        }
        return max;
    }

    public static int GoodGetSum(this int[] array, int n = 3)
    {
        int max = 0;
        int size = array.Length;
        for (int i = 0; i < n; i++) max += array[i];

        int t = max;
        for (int i = 1; i <= size - n; i++)
        {
            t = t - array[i - 1] + array[i + n - 1];
            if (t > max) max = t;
        }
        return max;
    }

    /// <summary>
    /// Считает сумму элементов массива
    /// </summary>
    /// <param name="array">Массив</param>
    /// <returns>Возвращает сумму элементов массива</returns>
    public static double SumAllElements(this int[] array)
    {
        double sum = 0;
        foreach (var item in array) sum += item;
        return sum;
    }

    /// <summary>
    /// Считает сумму упорядочных элементов массива 
    /// </summary>
    /// <param name="array">Массив</param>
    /// <returns>Возвращает сумму элементов массива</returns>
    public static double GoodSumAllElements(this int[] array) => (Convert.ToDouble(array[0]) + Convert.ToDouble(array[^1]))/2 * Convert.ToDouble(array.Length);
}