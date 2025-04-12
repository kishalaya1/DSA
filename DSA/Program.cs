// See https://aka.ms/new-console-template for more information
using Algorithms;
using Algo = Algorithms.Algorithms;
using System.Collections.Generic;



Console.WriteLine(" Alas! projects were as simple as displaying Hello, World!");

Dictionary<int, Action> functionMap = new Dictionary<int, Action>();
functionMap.Add(0, None);
functionMap.Add(1, BubbleSort);
functionMap.Add(2, RemoveDuplicateCharacters);
functionMap.Add(3, CheckWordsBeingAnagrams);
functionMap.Add(4, CheckWordBeingPalindrome);
functionMap.Add(5, CheckWordBeingHeterogram);
functionMap.Add(6, GetallSubstrings);
functionMap.Add(7, DisplayFactors);
functionMap.Add(8, DisplayHCF);
functionMap.Add(9, DisplayLCM);
functionMap.Add(10, CheckArmstrongNo);

string[] FuncNames = { "None","BubbleSort", "RemoveDuplicateCharacters", "CheckWordsBeingAnagrams", "CheckWordBeingPalindrome", "CheckWordBeingHeterogram", "GetallSubstrings", "DisplayFactors", "DisplayHCF", "DisplayLCM", "CheckArmstrongNo" };
Action[] selectedFuncs = {
    None,
    BubbleSort,
    RemoveDuplicateCharacters,
    CheckWordsBeingAnagrams,
    CheckWordBeingPalindrome,
    CheckWordBeingHeterogram,
    GetallSubstrings,
    DisplayFactors,
    DisplayHCF,
    DisplayLCM,
    CheckArmstrongNo
};

#region executable Func

Default(selectedFuncs, functionMap, FuncNames);

#endregion

#region Function Executed
static void Default(Action[] selectedFuncs, Dictionary<int, Action> functionMap, string[] funcNames)
{
    Console.WriteLine("Please select a no to execute the particualar algorithm example: ");
    foreach (var func in functionMap)
    {
       Console.WriteLine($"{func.Key} : {funcNames[func.Key]}");
    }   
    int FunctionNo = Convert.ToInt32(Console.ReadLine());
    selectedFuncs[FunctionNo]();
}
static void None()
{
    Console.WriteLine("No function selected to execute");
    Console.ReadKey();
}
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
static void DisplayFactors()
{
    Console.WriteLine("executing demo function to display factors of a number");
    int sampleNumber = 1024;
    Console.WriteLine("Sample number : " + sampleNumber);
    var lstFactors = Algo.GetFactors(sampleNumber);
    Console.WriteLine("The factors of the number are as follows : ");
    foreach (var factor in lstFactors)
    {
        Console.WriteLine(factor);
    }

    Console.ReadKey();
}
static void DisplayHCF()
{
    Console.WriteLine("executing demo function to show HCF of a given array of numbers");
    int[] arrNumbers = { 7, 49, 700 };
    foreach (int no in arrNumbers)
    {
        Console.WriteLine(no);
    }
    int hcfNo = Algo.GetHCFOfNos(arrNumbers);
    Console.WriteLine("The HCF is : ");
    Console.WriteLine(hcfNo);  
    Console.ReadKey();
}
static void DisplayLCM()
{
    Console.WriteLine("executing demo function to show LCM of a given array of numbers");
    int[] arrNumbers = { 2, 4, 6, 8 };
    foreach (int no in arrNumbers)
    {
        Console.WriteLine(no);
    }
    int lcmNo = Algo.GetHCFOfNos(arrNumbers);
    Console.WriteLine("The LCM is : ");
    Console.WriteLine(lcmNo);
    Console.ReadKey();
}

static void CheckArmstrongNo()
{
    Console.WriteLine("executing demo function to check if a number is an armstrong no");
    int sampleNo = 8208;
    Console.WriteLine("Sample number : " + sampleNo);
    string isArmstrongNo = (Algo.IsArmstrongNumber(sampleNo)) ? "Yes" : "No";
    Console.WriteLine("Is the given number an Armstrong number? : " + isArmstrongNo);
    Console.ReadKey();
}

#endregion