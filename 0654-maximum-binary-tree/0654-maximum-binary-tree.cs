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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return ConstructMaximumBinaryTree(nums,0,nums.Length-1);
    }
    public TreeNode ConstructMaximumBinaryTree(int[] nums, int leftIdx, int rightIdx){
        if(leftIdx>rightIdx) return null;
        int maxval=int.MinValue;
        int maxidx=-1;
        for(int i=leftIdx;i<=rightIdx;i++){
            if(nums[i]>maxval){
                maxidx=i;
                maxval=nums[i];
            }
        }
        TreeNode result = new TreeNode(maxval);
        result.left= ConstructMaximumBinaryTree(nums,leftIdx,maxidx-1);
        result.right= ConstructMaximumBinaryTree(nums,maxidx+1,rightIdx);
        return result;
        
    }
}