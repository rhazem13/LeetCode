public class FindElements {
    public TreeNode myroot;
    public FindElements(TreeNode root) {
        this.myroot=root;
        root.val=0;
        traverse(root);
    }
    public void traverse(TreeNode root){
        if(root==null)return;
        if(root.left!=null){
            root.left.val=2*root.val+1;
            traverse(root.left);
        }
        if(root.right!=null){
            root.right.val=2*root.val+2;
            traverse(root.right);
        }
    }
    
    public bool Find(int target) {
        return searchfortarget(this.myroot,target);
    }
    public bool searchfortarget(TreeNode root, int target){
        if(root==null)return false;
        if(root.val==target)return true;
        return searchfortarget(root.left,target)||searchfortarget(root.right,target);
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */