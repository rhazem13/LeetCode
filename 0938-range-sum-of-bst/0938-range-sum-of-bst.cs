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
    public int sum;
    public void dfs(TreeNode root, int low, int high){
        if(root!=null){
            if(root.val>=low && root.val <=high)
                sum+=root.val;
            dfs(root.left,low,high);
            dfs(root.right,low,high);
        }
    }
    public int RangeSumBST(TreeNode root, int low, int high) {
        sum=0;
        dfs(root,low,high);
        return sum;
    }
}