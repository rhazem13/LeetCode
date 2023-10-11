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
    int sum,depth;
    public void getDepth(TreeNode node, int curDepth){
        if(node==null) return;
        if(node.left==null && node.right==null) {
            depth=Math.Max(depth,curDepth);
        }
        else{
            getDepth(node.left, curDepth+1);
            getDepth(node.right, curDepth+1);
        }
    }
    public void getSum(TreeNode node,int curDepth){
        if(node==null) return;
        if(curDepth==depth)
            sum+=node.val;
        else{
            getSum(node.left,curDepth+1);
            getSum(node.right,curDepth+1);
        }
    }
    public int DeepestLeavesSum(TreeNode root) {
        sum=0;
        depth=0;
        getDepth(root,0);
        getSum(root,0);
        return sum;
    }
}