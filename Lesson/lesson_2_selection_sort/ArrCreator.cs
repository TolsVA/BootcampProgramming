namespace Algorithms;

public static class ArrCreator
{
    /// <summary>
    /// Заполняет массив рандомными числами
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">Нижняя граница диапазона случайных чисел</param>
    /// <param name="max">Верхняя граница диапазона случайных чисел</param>
    public static int[] FillRand(this int size, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0 ? new Random() : new Random(seed);
        return Enumerable.Range(1, size)
                .Select(item => random.Next(min, max))
                .ToArray();
    }

    /// <summary>
    /// Преобразует массив в строку
    /// </summary>
    /// <param name="array"></param>
    /// <param name="isPrint">Определяет вывод печати true или false</param>
    /// <returns>Строка с представлением массива</returns>
    public static int[] ConvetToString(this int[] array, string separator = ", ")
    {
        Console.WriteLine($"[{String.Join(separator, array)}]");
        return array;
    }
}
