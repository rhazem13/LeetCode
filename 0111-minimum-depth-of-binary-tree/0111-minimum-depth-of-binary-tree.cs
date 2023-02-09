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
    public int dfs(TreeNode root, int d){
        if(root==null)
            return Int32.MaxValue;
        if(root.left==null&&root.right==null)
            return d;
        return Math.Min(dfs(root.left,d+1),dfs(root.right,d+1));
    }
    public int MinDepth(TreeNode root) {
        if(root==null)
            return 0;
        return dfs(root,1);
    }
}