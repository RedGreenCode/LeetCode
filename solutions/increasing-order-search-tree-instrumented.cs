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
public class Solution {
    public TreeNode IncreasingBST(TreeNode root) {
        Console.WriteLine($"At root {root.val}");
        return IncreasingBST(root, null);
    }
    
    TreeNode IncreasingBST(TreeNode node, TreeNode next) {
        if (node == null) {
            var strNext = "null";
            if (next != null) strNext = next.val.ToString();
            Console.WriteLine("Node is null; returning next=" + strNext);
            return next;
        }
        
        var strLeft = Convert.ToString(node?.left?.val);
        if (strLeft == "") strLeft = "null";
        Console.WriteLine($"Recursive call with node={node.val}, node.left={strLeft}");
        var result = IncreasingBST(node.left, node);
        Console.WriteLine($"Saving result {result.val}");
        node.left = null;
        var strRight = Convert.ToString(node?.right?.val);
        if (strRight == "") strRight = "null";
        var strNext2 = Convert.ToString(next?.val);
        if (strNext2 == "") strNext2 = "null";
        Console.WriteLine($"Recursive call with node={node.val}, node.right={strRight}, next={strNext2}");
        node.right = IncreasingBST(node.right, next);
        strRight = Convert.ToString(node?.right?.val);
        if (strRight == "") strRight = "null";
        Console.WriteLine($"New node.right={strRight}");
        Console.WriteLine($"Returning result {result.val}");
        return result;
    }
}
