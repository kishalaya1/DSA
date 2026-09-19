using Algorithms;
using Xunit;

namespace TestDSAAlt;

public class SpecialAlgorithmTests
{
    public static IEnumerable<object[]> IsValidLuhnTestCases => new List<object[]>
    {
        new object[] { 4532015112830366L, true },
        new object[] { 79927398713L, true },
        new object[] { 0L, true },
        new object[] { 4532015112830367L, false },
        new object[] { 79927398710L, false },
        new object[] { -4532015112830366L, false },
        new object[] { 1L, false }
    };

    [Theory]
    [MemberData(nameof(IsValidLuhnTestCases))]
    public void IsValidLuhn_ValidatesCorrectly(long number, bool expected)
    {
        Assert.Equal(expected, SpecialAlgorithms.IsValidLuhn(number));
    }
}
