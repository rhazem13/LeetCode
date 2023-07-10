public class Solution {
    public int mindepth;
    public void helper(TreeNode root, int depth){
        if(root!=null){
            if(root.left==null && root.right==null){
                if(depth<mindepth)
                    mindepth=depth;
            }
            depth++;
            helper(root.left,depth);
            helper(root.right,depth);
        }
    }
    public int MinDepth(TreeNode root) {
        if(root==null) return 0;
        mindepth = Int32.MaxValue;
        helper(root,1);
        return mindepth;
    }
}