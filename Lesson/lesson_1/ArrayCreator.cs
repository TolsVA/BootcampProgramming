namespace Algorithms;

/// <summary>
/// Клас отвечающий за создание массива
/// </summary> <summary>
/// 
/// </summary>
public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="n">Количество элементов</param>
    /// <returns>новый массив</returns>
    public static int[] Create(this int n) => new int[n];

    /// <summary>
    /// Преобразует массив в строку
    /// </summary>
    /// <param name="array"></param>
    /// <param name="isPrint">Определяет вывод печати true или false</param>
    /// <returns>Строка с представлением массива</returns>
    public static string ConvetToString(this int[] array, string separator = ", ")
    {
        string str = $"[{String.Join(separator, array)}]";
        Console.WriteLine(str);
        return str;
    }

    /// <summary>
    /// Заполняет массив Random
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">Нижняя граница диапазона случайных чисел</param>
    /// <param name="max">Верхняя граница диапазона случайных чисел</param>
    public static int[] FillRandom(this int size, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0 ? new Random() : new Random(seed);
        return Enumerable.Range(1, size)
                .Select(item => random.Next(min, max))
                .ToArray();
    }

    /// <summary>
    /// Заполняет массив то min значения и до конца массива min++
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">min значение</param>
    /// <returns>Возвращает заполненый массив</returns>
    public static int[] FillOrder(this int[] array, int min = 0) => array.Select(item => min++).ToArray();
}
