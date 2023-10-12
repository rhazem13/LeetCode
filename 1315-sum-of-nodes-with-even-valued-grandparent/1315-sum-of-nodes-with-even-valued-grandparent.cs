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
    public void traverse(TreeNode root, bool evenFather, bool evenGrand){
        if(root==null) return;
        if(evenGrand)
            sum+=root.val;
        traverse(root.left,root.val%2==0,evenFather);
        traverse(root.right,root.val%2==0,evenFather);
    }
    public int SumEvenGrandparent(TreeNode root) {
        sum=0;
        traverse(root.left,root.val%2==0,false);
        traverse(root.right,root.val%2==0,false);
        return sum;
    }
}