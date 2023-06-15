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
    public int min;
    public int prev;
    public void check(TreeNode root){
        if(Math.Abs(root.val-prev)<min)
            min=Math.Abs(root.val-prev);
    }
    public void Traverse(TreeNode root){
            if(root != null){
                Traverse(root.left);
                check(root);
                prev=root.val;
                Traverse(root.right);
            }
    }
    public int GetMinimumDifference(TreeNode root) {
        min = Int32.MaxValue;
        prev=Int32.MaxValue;
        Traverse(root);
        return min;
    }
}