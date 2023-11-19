using Algorithms;
using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = 100_000.FillRandom(min: 1, max: 10);

        int max;
        int n = 10_000;
        Stopwatch sw = new Stopwatch();

        sw.Start();
        max = array.BedGetSum(n);
        sw.Stop();
        Console.WriteLine($"BedGetSum -> {max} Время выполнения -> {sw.ElapsedMilliseconds}");

        sw.Reset();

        sw.Start();
        max = array.GoodGetSum(n);
        sw.Stop();
        Console.WriteLine($"GoodGetSum -> {max} Время выполнения -> {sw.ElapsedMilliseconds}");

        int min = 7;
        double sum;
        int[] arr = 100_000_000.Create()
                       .FillOrder(min);
        // arr.ConvetToString(", ");

        sw.Reset();
        sw.Start();
        sum = arr.SumAllElements();
        sw.Stop();
        Console.WriteLine($"SumAllElements -> {sum} Время выполнения -> {sw.ElapsedMilliseconds}");

        sw.Reset();
        sw.Start();
        sum = arr.GoodSumAllElements();
        sw.Stop();
        Console.WriteLine($"SumAllElements -> {sum} Время выполнения -> {sw.ElapsedMilliseconds}");


        n = 5;
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrix[i, j] = (j + 1) * (i + 1);
                matrix[j, i] = (j + 1) * (i + 1);
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                System.Console.Write($"{matrix[i, j]}\t");
            }
            System.Console.WriteLine();
        }
    }
}