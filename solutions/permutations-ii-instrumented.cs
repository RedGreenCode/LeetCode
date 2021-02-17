public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        backtrack(nums.ToList(), 0, result);
        return result;
    }
    
    void backtrack(List<int> nums, int i, List<IList<int>> result) {
        if (i == nums.Count) {
            Console.WriteLine($"i={i}, adding to result:");
            Console.Write("--> ");
            print(nums);
            result.Add(nums);
            return;
        }
        
        for (var j=i; j<nums.Count; j++) {
            if (j == i || nums[i] != nums[j]) {
                Console.WriteLine($"i={i}, j={j}");
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                print(nums);
                backtrack(new List<int>(nums), i+1, result);
                Console.WriteLine($"Returned from backtrack at i={i}, j={j}");
            }
        }
    }
    
    void print(List<int> nums) {
        foreach (var num in nums) Console.Write($"{num} ");
        Console.WriteLine();
    }
}
