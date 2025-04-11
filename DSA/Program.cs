// See https://aka.ms/new-console-template for more information
using Algorithms;
using Algo = Algorithms.Algorithms;
using System.Collections.Generic;



Console.WriteLine("Hello, World!");

#region executable Func
//BubbleSort();
//RemoveDuplicateCharacters();
//CheckWordsBeingAnagrams();
//CheckWordBeingPalindrome();
//CheckWordBeingHeterogram();
GetallSubstrings();

#endregion

#region Function Executed
static void BubbleSort()
{
    Console.WriteLine("executing BubbleSort Demo with an Example:");
    int[] array = { 64, 34, 25, 12, 22, 11, 90 };
    Console.WriteLine("Unsorted array:");
    Console.WriteLine(string.Join(", ", array));

    int[] sortedArray = Algo.BubbleSort(array);

    Console.WriteLine("Sorted array:");
    Console.WriteLine(string.Join(", ", sortedArray));
    Console.ReadKey();
}
static void RemoveDuplicateCharacters()
{
    Console.WriteLine("Executing remove duplicate characters from a string");
    string wordwithRepeatingChars = "Mississippi";
    Console.WriteLine("Raw word with duplicate characters : " + wordwithRepeatingChars);
    string cleanedWord = Algo.RemoveDuplicateChars(wordwithRepeatingChars);

    Console.WriteLine("word or string cleaned of duplicate characters : " + cleanedWord);

    Console.ReadKey();
}
static void CheckWordsBeingAnagrams()
{
    Console.WriteLine("executing demo function to check if two words are Anagrams");
    string firstWord = "Listen";
    string secondWord = "Enlist";

    Console.WriteLine("First word : " + firstWord);
    Console.WriteLine("Second word : " + secondWord);
    string areBothAnagrams = (Algo.AreAnagrams(firstWord, secondWord)) ? "Yes" : "No";
    Console.WriteLine("Are both words Anagrams? : " + areBothAnagrams);
    Console.ReadKey();
}

static void CheckWordBeingPalindrome()
{
    Console.WriteLine("executing demo function to check if a word is palindrome");
    string sampleWord = "Malayalam"; 
    Console.WriteLine("Sample word : " + sampleWord);
    string isPalindrome = (Algo.IsPalindrome(sampleWord)) ? "Yes" : "No";
    Console.WriteLine("Is the given word a Palindrome  ? : " + isPalindrome);
    Console.ReadKey();
}
static void CheckWordBeingHeterogram()
{
    Console.WriteLine("executing demo function to check if a word has all unique characters(Heterogram)");
    string sampleWord = "abcdef";
    Console.WriteLine("Sample word : " + sampleWord);
    string isPalindrome = (Algo.IsHeterogram(sampleWord)) ? "Yes" : "No";
    Console.WriteLine("Is the given word a Heterogram  ? : " + isPalindrome);
    Console.ReadKey();
}
static void GetallSubstrings()
{
    Console.WriteLine("executing demo function to get all substrings from a word");
    string sampleWord = "abc";
    Console.WriteLine("Sample word : " + sampleWord);
    var lstStrings = Algo.GetAllSubstrings(sampleWord);
    Console.WriteLine("All substrings of the word are as follows : ");
    foreach (var word in lstStrings)
    {
        Console.WriteLine(word);
    }
  
    Console.ReadKey();
}

#endregion