// 1288. Remove Covered Intervals (Medium)
// Solution source: https://leetcode.com/problems/remove-covered-intervals/discuss/451277/JavaC%2B%2BPython-Sort-Solution
//
// Runtime: 108 ms, faster than 84.62% of C# online submissions for Remove Covered Intervals.
// Memory Usage: 29.4 MB, less than 82.03% of C# online submissions for Remove Covered Intervals.
//
public class Solution {
    public int RemoveCoveredIntervals(int[][] A) {
        var count = 0;
        var left = -1;
        var right = -1;
        
        Array.Sort(A, (a,b) => { return a[0] < b[0] ? -1 : 1; } );
        foreach (var v in A) {
            if (v[0] > left && v[1] > right) {
                left = v[0];
                count++;
            }
            right = Math.Max(right, v[1]);
        }
        
        return count;
    }
}
