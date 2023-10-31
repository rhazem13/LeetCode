
public class Solution {
    int maxV=0;
    public void traverse(TreeNode node, int minAncest, int maxAncest){
        if(node==null)return;
        if(Math.Max(Math.Abs(node.val-minAncest),Math.Abs(node.val-maxAncest))>maxV){
            maxV=Math.Max(Math.Abs(node.val-minAncest),Math.Abs(node.val-maxAncest));
        }
        minAncest=Math.Min(node.val,minAncest);
        maxAncest=Math.Max(node.val,maxAncest);
        traverse(node.left,minAncest,maxAncest);
        traverse(node.right,minAncest,maxAncest);
    }   
    public int MaxAncestorDiff(TreeNode root) {
        traverse(root.left,root.val,root.val);
        traverse(root.right,root.val,root.val);
        return maxV;
    }
}