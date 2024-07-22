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
    Dictionary<int, IList<TreeNode>> memo = new();
    public IList<TreeNode> AllPossibleFBT(int n) {
        if(!memo.ContainsKey(n)){
            List<TreeNode> list=new();
            if(n==1){
                list.Add(new TreeNode(0));
            } else {
                if(n%2==1){
                    for(int i=0;i<n;i++){
                        int j = n-i-1;
                        foreach(TreeNode left in AllPossibleFBT(i)){
                            foreach(TreeNode right in AllPossibleFBT(j)){
                                TreeNode root=new TreeNode(0);
                                root.left=left;
                                root.right=right;
                                list.Add(root);
                            }
                        }
                    }
                }
            }
            memo[n]=list;
        }
        return memo[n];
    }
}