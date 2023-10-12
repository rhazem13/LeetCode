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
    int sum;
    public void getSum(TreeNode root){
        if(root==null)return;
        sum+=root.val;
        getSum(root.left);
        getSum(root.right);
    }
    public void inOrder(TreeNode root){
        if(root==null)return;
        inOrder(root.left);
        int tmp=root.val;
        root.val=sum;
        sum-=tmp;
        inOrder(root.right);
    }
    public TreeNode BstToGst(TreeNode root) {
        sum=0;
        // get tree sum
        getSum(root);
        // do inorder traversal and remove the node val from sum each step xd
        inOrder(root);
        return root;
    }
}