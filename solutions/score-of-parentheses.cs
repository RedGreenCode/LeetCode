// 856. Score of Parentheses (Medium)
// Solution source: https://leetcode.com/problems/score-of-parentheses/solution/
// 
// Runtime: 68 ms, faster than 97.06% of C# online submissions for Score of Parentheses.
// Memory Usage: 22.8 MB, less than 20.59% of C# online submissions for Score of Parentheses.
public class Solution {
    public int ScoreOfParentheses(string S) {
        var result = 0;
        var balance = 0;
        
        for (var i=0; i<S.Length; i++) {
            if (S[i] == '(') {
                balance++;
            } else {
                balance--;
                if (S[i-1] == '(')
                    result += 1 << balance;
            }
        }
        
        return result;
    }
}
