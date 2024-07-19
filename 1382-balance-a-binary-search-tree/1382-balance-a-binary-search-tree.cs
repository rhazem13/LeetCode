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
    public TreeNode BalanceBST(TreeNode root) {
        // create sorted array using inorder traversal
        List<int> arr = new();
        InOrder(root,arr);
        // now create balanced bst using the sorted array
        TreeNode newRoot= new TreeNode();
        return CreateBalancedBinarySearchTree(arr, 0, arr.Count-1);
    }

    public void InOrder(TreeNode root, List<int> arr){
        if(root==null) return;
        InOrder(root.left, arr);
        arr.Add(root.val);
        InOrder(root.right, arr);
    }

    public TreeNode CreateBalancedBinarySearchTree(List<int> arr, int j, int k){
        if(j>k) return null;
        int m = j + (k-j) / 2;
        TreeNode node = new TreeNode(arr[m]);
        node.left= CreateBalancedBinarySearchTree(arr,j,m-1);
        node.right= CreateBalancedBinarySearchTree(arr,m+1,k);
        return node;
    }
}