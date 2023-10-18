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
    List<int> t1;
    List<int> t2;
    public void inorder(TreeNode root,int num){
        if(root==null) return;
        inorder(root.left,num);
        if(num==1)
            t1.Add(root.val);
        else
            t2.Add(root.val);
        inorder(root.right,num);
    }
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        List<int> res=new();
        t1=new();
        t2=new();
        inorder(root1,1);
        inorder(root2,2);
        int i1=0,i2=0;
        while(i1<t1.Count||i2<t2.Count){
            if(i1>=t1.Count){
                res.Add(t2[i2]);
                i2++;
            }
            else if(i2>=t2.Count){
                res.Add(t1[i1]);
                i1++;
            }
            else if(t1[i1]<t2[i2]){
                res.Add(t1[i1]);
                i1++;
            }
            else{
                res.Add(t2[i2]);
                i2++;
            }
        }
        return res;
    }
}