namespace LeetCode;

public class LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        if (s.Length == 1)
        {
            return s;
        }
        var longest = "";
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = s.Length - 1; j >= i; j--)
            {
                if (s[i] == s[j])
                {
                    var possibleString = s[(i)..(j + 1)];
                    if (IsPalindrome(possibleString) && possibleString.Length > longest.Length)
                    {
                        longest = possibleString;
                    }
                }
            }
        }

        return longest;
    }

    private static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}