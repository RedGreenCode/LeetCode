// 227. Basic Calculator II (Medium)
// Solution source: https://leetcode.com/problems/basic-calculator-ii/solution/
//
// Runtime: 76 ms, faster than 88.91% of C# online submissions for Basic Calculator II.
// Memory Usage: 24.5 MB, less than 93.70% of C# online submissions for Basic Calculator II.
//
public class Solution {
    public int Calculate(string s) {
        s = s.Replace(" ", string.Empty);
        var len = s.Length;
        int num = 0, prev = 0, result = 0;
        char op = '+';
        
        for (var i=0; i<len; i++) {
            char c = s[i];
            if (char.IsDigit(c)) num = num*10 + (c - '0');
            if (!char.IsDigit(c) || i==len-1) {
                if (op=='+' || op=='-') {
                    result += prev;
                    prev = (op == '+') ? num : -num;
                } else if (op == '*') {
                    prev *= num;
                } else if (op == '/') {
                    prev /= num;
                }
                op = c;
                num = 0;
            }
        }

        result += prev;
        return result;
    }
}
