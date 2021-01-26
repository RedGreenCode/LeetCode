/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
// 1022. Sum of Root To Leaf Binary Numbers (Easy)
// Solution source: https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/discuss/270025/JavaC%2B%2BPython-Recursive-Solution
//
// Runtime: 100 ms, faster than 56.48% of C# online submissions
// Memory Usage: 24.3 MB, less than 89.82% of C# online submissions
//
// Runtime: 88 ms, faster than 98.06% of C# online submissions
// Memory Usage: 24.3 MB, less than 83.49% of C# online submissions
public class Solution {
    public int SumRootToLeaf(TreeNode root) {
        return dfs(root, 0);
    }
    
    int dfs(TreeNode node, int sum) {
        if (node == null) return 0;
        
        sum = 2*sum + node.val;
        return (node.left == node.right) ? sum :
            dfs(node.left, sum) + dfs(node.right, sum);
    }
}
