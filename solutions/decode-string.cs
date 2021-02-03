// 394. Decode String (Medium)
// https://leetcode.com/problems/decode-string/
//
// Runtime: 80 ms, faster than 86.33% of C# online submissions for Decode String.
// Memory Usage: 23.6 MB, less than 26.68% of C# online submissions for Decode String.
// 
// Solution source: https://leetcode.com/problems/decode-string/discuss/87543/0ms-simple-C++-solution/92445
public class Solution {
    int pos = 0;
    
    public string DecodeString(string s) {
        var sb = new StringBuilder();
        
        while (pos < s.Length) {
            if (char.IsDigit(s[pos])) {
                var n = 0;
                while (char.IsDigit(s[pos]))
                    n = n*10+(s[pos++] - '0');
                var nested = DecodeString(s);
                for (var i=0; i<n; i++)
                    sb.Append(nested);
            }
            else if (char.IsLetter(s[pos]))
                sb.Append(s[pos++]);
            else if (s[pos++] == ']')
                return sb.ToString();
        }
        
        return sb.ToString();
    }
}
