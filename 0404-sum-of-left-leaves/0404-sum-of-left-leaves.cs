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
    public void sumLeft(TreeNode root,ref int sum){
        if(root!=null){
            if(root.left!=null){
                if(root.left.left==null && root.left.right==null)
                    sum+=root.left.val;
            }
            sumLeft(root.left,ref sum);
            sumLeft(root.right, ref sum);
        }
    }
    public int SumOfLeftLeaves(TreeNode root) {
        int sum=0;
        sumLeft(root,ref sum);
        return sum;
    }
}