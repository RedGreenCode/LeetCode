// 47. Permutations II (Medium)
// Solution source: https://leetcode.com/problems/permutations-ii/discuss/18669/C%2B%2B-backtracking-and-nextPermutation
// Official solution: https://leetcode.com/problems/permutations-ii/solution/
//
// Runtime: 240 ms, faster than 92.02% of C# online submissions for Permutations II.
// Memory Usage: 33.4 MB, less than 96.16% of C# online submissions for Permutations II.
public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        permute(nums.ToList(), 0, result);
        return result;
    }
    
    void permute(List<int> nums, int i, List<IList<int>> result) {
        if (i == nums.Count) {
            result.Add(nums);
            return;
        }

        for (var j=i; j<nums.Count; j++) {
            if (j == i || nums[j] != nums[i]) {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                permute(new List<int>(nums), i+1, result);
            }
        }
    }
}
