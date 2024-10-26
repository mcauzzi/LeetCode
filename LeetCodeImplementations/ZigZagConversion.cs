namespace LeetCode;

public class ZigZagConversion
{
    public string Convert(string s, int numRows)
    {
        if (s.Length <= 1 || numRows == 1)
        {
            return s;
        }

        var result = Enumerable.Repeat("", numRows).ToArray();
        
        var row = 0;
        for(int i=0;i<s.Length;i++)
        {
            result[row] += s[i];
            
            if (row == numRows-1)
            {
                while(row>0 && i<s.Length-1)
                {
                    result[--row] += s[++i];
                }
            }

            row++;
        }
        
        return string.Join("", result);
    }
}