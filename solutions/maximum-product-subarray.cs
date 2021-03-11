// 152. Maximum Product Subarray (Medium)
// Solution source: https://leetcode.com/problems/maximum-product-subarray/discuss/183483/JavaC%2B%2BPython-it-can-be-more-simple
//
// Runtime: 84 ms, faster than 98.14% of C# online submissions for Maximum Product Subarray.
// Memory Usage: 24.2 MB, less than 99.10% of C# online submissions for Maximum Product Subarray.
public class Solution {
    public int MaxProduct(int[] nums) {
        var len = nums.Length;
        if (len == 0) return 0;
        var max = nums[0];
        var left = 0;
        var right = 0;
        
        for (var i=0; i<len; i++) {
            left = (left == 0 ? 1 : left) * nums[i];
            right = (right == 0 ? 1 : right) * nums[len-1-i];
            max = Math.Max(max, Math.Max(left, right));
        }
        
        return max;
    }
}
