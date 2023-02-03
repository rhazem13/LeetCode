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
    public List<int> orderedArr;
    public void inorder(TreeNode root){
        if(root!=null){
            inorder(root.left);        
            orderedArr.Add(root.val);
            inorder(root.right); 
        }       
    }
    
    public int KthSmallest(TreeNode root, int k) {
        orderedArr=new();
        inorder(root);
        return orderedArr[k-1];
    }
}