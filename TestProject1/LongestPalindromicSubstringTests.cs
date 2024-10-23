using LeetCode;

namespace TestProject1;

public class LongestPalindromicSubstringTests
{
    public LongestPalindromicSubstringTests()
    {
        Impl = new LongestPalindromicSubstring();
    }

    private LongestPalindromicSubstring Impl { get; set; }

    [Theory]
    [InlineData("babad", "bab")]
    [InlineData("cbbd", "bb")]
    [InlineData("a", "a")]
    [InlineData("ac", "a")]
    [InlineData("", "")]
    [InlineData("abb", "bb")]
    [InlineData("jglknendplocymmvwtoxvebkekzfdhykknufqdkntnqvgfbahsljkobhbxkvyictzkqjqydczuxjkgecdyhixdttxfqmgksrkyvopwprsgoszftuhawflzjyuyrujrxluhzjvbflxgcovilthvuihzttzithnsqbdxtafxrfrblulsakrahulwthhbjcslceewxfxtavljpimaqqlcbrdgtgjryjytgxljxtravwdlnrrauxplempnbfeusgtqzjtzshwieutxdytlrrqvyemlyzolhbkzhyfyttevqnfvmpqjngcnazmaagwihxrhmcibyfkccyrqwnzlzqeuenhwlzhbxqxerfifzncimwqsfatudjihtumrtjtggzleovihifxufvwqeimbxvzlxwcsknksogsbwwdlwulnetdysvsfkonggeedtshxqkgbhoscjgpiel",
                   "sknks")]
    public void Test1(string input, string expected)
    {
        var result = Impl.LongestPalindrome(input);
        Assert.Equal(expected, result);
    }
}