namespace Algorithms;

public static class Sorted
{
    /// <summary>
    /// Сортируем массив по методу выбора от минимума
    /// </summary>
    /// <param name="arr">Заданый массив</param>
    /// <returns>Отсортированный массив</returns> <summary>
    public static int[] SortSelectionMin(this int[] arr)
    {
        int size = arr.Length;
        for (int i = 0; i < size - 1; i++)
        {
            int pos = i;
            for (int j = i + 1; j < size; j++)
            {
                if (arr[j] < arr[pos]) pos = j;
            }
            int tepm = arr[i];
            arr[i] = arr[pos];
            arr[pos] = tepm;
        }
        return arr;
    }

        public static int[] SortSelectionMax(this int[] arr)
    {
        int size = arr.Length;
        for (int i = 0; i < size - 1; i++)
        {
            int pos = i;
            for (int j = i + 1; j < size; j++)
            {
                if (arr[j] > arr[pos]) pos = j;
            }
            int tepm = arr[i];
            arr[i] = arr[pos];
            arr[pos] = tepm;
        }
        return arr;
    }
}
