using Algorithms;
using Xunit;

namespace TestDSAAlt;

public class AlgorithmTests
{
    public static IEnumerable<object[]> BubbleSortTestCases => new List<object[]>
    {
        new object[] { new[] { 64, 34, 25, 12, 22, 11, 90 }, new[] { 11, 12, 22, 25, 34, 64, 90 } },
        new object[] { new[] { 5, 3, 8, 4, 2 }, new[] { 2, 3, 4, 5, 8 } },
        new object[] { new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 } },
        new object[] { new[] { 9, 7, 5, 3, 1 }, new[] { 1, 3, 5, 7, 9 } },
        new object[] { new[] { 9, 28, 35, 54, 52, 2, 0 }, new[] { 0, 2, 9, 28, 35, 52, 54 } },
        new object[] { Array.Empty<int>(), Array.Empty<int>() }
    };

    [Theory]
    [MemberData(nameof(BubbleSortTestCases))]
    public void BubbleSort_SortsArrayCorrectly(int[] input, int[] expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.BubbleSort(input));
    }

    public static IEnumerable<object[]> RemoveDuplicateCharsTestCases => new List<object[]>
    {
        new object[] { "hello", "helo" }, new object[] { "world", "world" },
        new object[] { "aabbcc", "abc" }, new object[] { "abcabc", "abc" },
        new object[] { "", "" }, new object[] { "a", "a" },
        new object[] { "Mississippi", "Misp" }, new object[] { "voodoo", "vod" },
        new object[] { "aa", "a" }
    };

    [Theory]
    [MemberData(nameof(RemoveDuplicateCharsTestCases))]
    public void RemoveDuplicateChars_RemovesDuplicatesCorrectly(string input, string expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.RemoveDuplicateChars(input));
    }

    public static IEnumerable<object[]> AreAnagramsTestCases => new List<object[]>
    {
        new object[] { "listen", "silent", true }, new object[] { "triangle", "integral", true },
        new object[] { "apple", "pale", false }, new object[] { "rat", "car", false },
        new object[] { "night", "thing", true }, new object[] { "dusty", "study", true },
        new object[] { "", "", false }, new object[] { "a", "a", true },
        new object[] { "a", "b", false }, new object[] { "rat", "rats", false }
    };

    [Theory]
    [MemberData(nameof(AreAnagramsTestCases))]
    public void AreAnagrams_DetectsAnagramsCorrectly(string firstWord, string secondWord, bool expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.AreAnagrams(firstWord, secondWord));
    }

    public static IEnumerable<object[]> IsPalindromeTestCases => new List<object[]>
    {
        new object[] { "racecar", true }, new object[] { "RaceCar", true },
        new object[] { "hello", false }, new object[] { "A", true },
        new object[] { "", true }, new object[] { "madam", true },
        new object[] { "Madam", true }, new object[] { "step on no pets", true },
        new object[] { "Malayalam", true }, new object[] { "civic", true },
        new object[] { "hannah", true }, new object[] { "tattarrattat", true }
    };

    [Theory]
    [MemberData(nameof(IsPalindromeTestCases))]
    public void IsPalindrome_DetectsPalindromeCorrectly(string input, bool expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.IsPalindrome(input));
    }

    public static IEnumerable<object[]> IsHeterogramTestCases => new List<object[]>
    {
        new object[] { "abcdefg", true }, new object[] { "hello", false },
        new object[] { "world", true }, new object[] { "aabbcc", false },
        new object[] { "", true }, new object[] { "abcABC", false },
        new object[] { "Heterogram", false }, new object[] { "a!@#rb", true }
    };

    [Theory]
    [MemberData(nameof(IsHeterogramTestCases))]
    public void IsHeterogram_DetectsHeterogramCorrectly(string word, bool expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.IsHeterogram(word));
    }

    public static IEnumerable<object[]> GetAllSubstringsTestCases => new List<object[]>
    {
        new object[] { "abc", new List<string> { "a", "ab", "abc", "b", "bc", "c" } },
        new object[] { "ab", new List<string> { "a", "ab", "b" } },
        new object[] { "a", new List<string> { "a" } },
        new object[] { "", new List<string>() },
        new object[] { "xyz", new List<string> { "x", "xy", "xyz", "y", "yz", "z" } }
    };

    [Theory]
    [MemberData(nameof(GetAllSubstringsTestCases))]
    public void GetAllSubstrings_ReturnsCorrectSubstrings(string word, List<string> expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.GetAllSubstrings(word));
    }

    public static IEnumerable<object[]> IsPangramTestCases => new List<object[]>
    {
        new object[] { "The quick brown fox jumps over the lazy dog", true },
        new object[] { "Sphinx of black quartz, judge my vow", true },
        new object[] { "Pack my box with five dozen liquor jugs", true },
        new object[] { "The quick brown fox jumps over the dog", false },
        new object[] { "", false }, new object[] { "ABCDEFGHIJKLMNOPQRSTUVWXYZ", true },
        new object[] { "abcdefghijklmnopqrstuvwxy", false },
        new object[] { "the quick brown fox jumps over the lazy dog 12345 !@#", true },
        new object[] { "How vexingly quick daft zebras jump", true },
        new object[] { "The five boxing wizards jump quickly", true },
        new object[] { "Crazy Fredrick bought many very exquisite opal jewels", true },
        new object[] { "Mr. Jock, TV quiz PhD, bags few lynx", true }
    };

    [Theory]
    [MemberData(nameof(IsPangramTestCases))]
    public void IsPangram_DetectsPangramCorrectly(string sentence, bool expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.IsPangram(sentence));
    }

    public static IEnumerable<object[]> GetFactorsTestCases => new List<object[]>
    {
        new object[] { 12, new List<int> { 1, 2, 3, 4, 6, 12 } },
        new object[] { 15, new List<int> { 1, 3, 5, 15 } },
        new object[] { 28, new List<int> { 1, 2, 4, 7, 14, 28 } },
        new object[] { 1, new List<int> { 1 } }, new object[] { 0, new List<int>() }
    };

    [Theory]
    [MemberData(nameof(GetFactorsTestCases))]
    public void GetFactors_ReturnsCorrectFactors(int number, List<int> expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.GetFactors(number).OrderBy(value => value));
    }

    public static IEnumerable<object[]> GetHCFTestCases => new List<object[]>
    {
        new object[] { new[] { 48, 18 }, 6 }, new object[] { new[] { 7, 13 }, 1 },
        new object[] { new[] { 0, 18 }, 18 }, new object[] { new[] { 0, 0 }, 0 },
        new object[] { new[] { 48, 18, 30 }, 6 }, new object[] { new[] { 12, 15, 21 }, 3 },
        new object[] { new[] { 8, 16, 32 }, 8 }, new object[] { new[] { 1, 1, 1 }, 1 },
        new object[] { new[] { 1, 0 }, 1 }, new object[] { new[] { 100 }, 100 }
    };

    [Theory]
    [MemberData(nameof(GetHCFTestCases))]
    public void GetHCF_ReturnsCorrectHCF(int[] numbers, int expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.GetHCFOfNos(numbers));
    }

    public static IEnumerable<object[]> GetLCMTestCases => new List<object[]>
    {
        new object[] { new[] { 4, 6 }, 12 }, new object[] { new[] { 7, 13 }, 91 },
        new object[] { new[] { 0, 18 }, 0 }, new object[] { new[] { 0, 0 }, 0 },
        new object[] { new[] { 4, 6, 8 }, 24 }, new object[] { new[] { 12, 15, 20 }, 60 },
        new object[] { new[] { 8, 16, 32 }, 32 }, new object[] { new[] { 1, 1, 1 }, 1 },
        new object[] { new[] { 1, 0 }, 0 }, new object[] { new[] { 100 }, 100 }
    };

    [Theory]
    [MemberData(nameof(GetLCMTestCases))]
    public void GetLCM_ReturnsCorrectLCM(int[] numbers, int expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.GetLCMOfNos(numbers));
    }

    public static IEnumerable<object[]> IsArmstrongNumberTestCases => new List<object[]>
    {
        new object[] { 153, true }, new object[] { 9474, true }, new object[] { 8208, true },
        new object[] { 9475, false }, new object[] { 0, true }, new object[] { 1, true },
        new object[] { 123, false }, new object[] { 10, false },
        new object[] { -153, false }, new object[] { -8208, false }
    };

    [Theory]
    [MemberData(nameof(IsArmstrongNumberTestCases))]
    public void IsArmstrongNumber_DetectsCorrectly(int number, bool expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.IsArmstrongNumber(number));
    }

    public static IEnumerable<object[]> IsPowerOfTestCases => new List<object[]>
    {
        new object[] { 1, 2, true }, new object[] { 2, 2, true }, new object[] { 4, 2, true },
        new object[] { 8, 2, true }, new object[] { 3, 2, false }, new object[] { 16, 4, true },
        new object[] { 27, 3, true }, new object[] { 729, 3, true }, new object[] { 0, 2, false },
        new object[] { -8, 2, false }
    };

    [Theory]
    [MemberData(nameof(IsPowerOfTestCases))]
    public void IsPowerOf_ReturnsCorrectResult(int number, int baseNumber, bool expected)
    {
        Assert.Equal(expected, Algorithms.Algorithms.IsPowerOf(number, baseNumber));
    }
}
