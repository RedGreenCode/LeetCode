// 322. Coin Change (Medium)
// Solution source: https://leetcode.com/problems/coin-change/discuss/77373/6-7-lines-2-ways
// 
// Runtime: 88 ms, faster than 99.86% of C# online submissions for Coin Change.
// Memory Usage: 27.9 MB, less than 66.29% of C# online submissions for Coin Change.
public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var dp = new int[amount+1];
        for (var i=1; i<amount+1; i++) dp[i] = amount+1;
        
        foreach (var c in coins) {
            for (var i=c; i<=amount; i++) {
                dp[i] = Math.Min(dp[i], dp[i-c] + 1);
            }
        }
        
        return dp[amount] == amount + 1 ? -1 : dp[amount];
    }
}
