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
    public void traverse(TreeNode left, TreeNode right, bool isOdd){
        if(left==null||right==null)return;
        if(isOdd){
            int tmp = left.val;
            left.val=right.val;
            right.val=tmp;
        }
        traverse(left.left,right.right,!isOdd);
        traverse(right.left,left.right,!isOdd);
    }
    public TreeNode ReverseOddLevels(TreeNode root) {
        traverse(root.left,root.right,true);
        return root;
    }
}