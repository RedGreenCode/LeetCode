// 11. Container With Most Water (Medium)
// Solution source: https://leetcode.com/problems/container-with-most-water/discuss/6100/Simple-and-clear-proofexplanation
// 
// Runtime: 116 ms, faster than 59.45% of C# online submissions for Container With Most Water.
// Memory Usage: 30.8 MB, less than 9.16% of C# online submissions for Container With Most Water.
public class Solution {
    public int MaxArea(int[] height) {
        var i = 0;
        var j = height.Length-1;
        var max = 0;
        
        while (i < j) {
            max = Math.Max(max, Math.Min(height[i], height[j]) * (j-i));
            if (height[i] < height[j]) i++;
            else j--;
        }
        
        return max;
    }
}
