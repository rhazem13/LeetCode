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
    public TreeNode d7k(int[] nums,int l,int r){
        if(l<=r){
            int i=r+(l-r)/2;
            TreeNode tmp = new TreeNode(nums[i]);
            tmp.left=d7k(nums,l,i-1);
            tmp.right=d7k(nums,i+1,r);

            return tmp;
        }
        return null;
    }
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums == null || nums.Length == 0)
            return null;
        return d7k(nums,0,nums.Length-1);
    }
}