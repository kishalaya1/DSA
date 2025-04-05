// See https://aka.ms/new-console-template for more information
using DSA;

Console.WriteLine("Hello, World!");

#region executableFunc
BubbleSort();

#endregion

#region executableFunc
static void BubbleSort()
{
    Console.WriteLine("executing BubbleSort Demo with an Example:");
    int[] array = { 64, 34, 25, 12, 22, 11, 90 };
    Console.WriteLine("Unsorted array:");
    Console.WriteLine(string.Join(", ", array));

    int[] sortedArray = Algorithms.BubbleSort(array);

    Console.WriteLine("Sorted array:");
    Console.WriteLine(string.Join(", ", sortedArray));
    Console.ReadKey();
}

#endregion