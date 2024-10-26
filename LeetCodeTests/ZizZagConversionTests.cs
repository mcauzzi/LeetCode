using LeetCode;

namespace LeetCodeTests;

public class ZizZagConversionTests
{
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    [InlineData("AB", 1, "AB")]
    public void Test1(string input, int numRows, string expected)
    {
        var result = new ZigZagConversion().Convert(input, numRows);
        Assert.Equal(expected, result);
    }
    
}