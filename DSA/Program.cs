// See https://aka.ms/new-console-template for more information
using DSA;

Console.WriteLine("Hello, World!");

#region executable Func
//BubbleSort();
RemoveDuplicateCharacters();

#endregion

#region Function Executed
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
static void RemoveDuplicateCharacters()
{
    Console.WriteLine("Executing remove duplicate characters from a string");
    string wordwithRepeatingChars = "Mississippi";
    Console.WriteLine("Raw word with duplicate characters : " + wordwithRepeatingChars);
    string cleanedWord = Algorithms.RemoveDuplicateChars(wordwithRepeatingChars);

    Console.WriteLine("word or string cleaned of duplicate characters : " + cleanedWord);
    
    Console.ReadKey();
}


#endregion