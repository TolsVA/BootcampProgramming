using Algorithms;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {

        Stopwatch sw = new Stopwatch();
        int[] array = 10.FillRand(min: 1, max: 10)
                        .ConvetToString(", ")
                        .SortSelectionMin()
                        .ConvetToString(", ")
                        .SortSelectionMax()
                        .ConvetToString(", ");


    }
}