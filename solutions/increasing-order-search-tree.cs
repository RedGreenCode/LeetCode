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
// 897. Increasing Order Search Tree (Easy)
//
// Runtime: 100 ms, faster than 7.19% of C# online submissions for Increasing Order Search Tree.
// Memory Usage: 24.9 MB, less than 17.99% of C# online submissions for Increasing Order Search Tree.
//
// Solution source: https://leetcode.com/problems/increasing-order-search-tree/discuss/165885/C%2B%2BJavaPython-Self-Explained-5-line-O(N)
public class Solution {
    public TreeNode IncreasingBST(TreeNode root) {
        return IncreasingBST(root, null);
    }
    
    TreeNode IncreasingBST(TreeNode node, TreeNode next) {
        if (node == null) return next;
        var result = IncreasingBST(node.left, node);
        node.left = null;
        node.right = IncreasingBST(node.right, next);
        return result;
    }
}
