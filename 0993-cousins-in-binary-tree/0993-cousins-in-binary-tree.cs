
public class Solution {
    public int xd, xp, yd, yp;
    public void helper(TreeNode root, int x, int y, int parent, int depth){
        if(root!=null)
        {
            if(root.val==x){
                xd= depth;
                xp= parent;
            }
                
            if(root.val==y){
                yd=depth;
                yp=parent;
            }
            depth++;
            parent=root.val;
            helper(root.left,x,y,parent,depth);
            helper(root.right,x,y,parent,depth);
        }
    }
    public bool IsCousins(TreeNode root, int x, int y) {
        helper(root,x,y,0,1);
        if((xd==yd)&&(xp!=yp))
            return true;
        return false;
    }
}