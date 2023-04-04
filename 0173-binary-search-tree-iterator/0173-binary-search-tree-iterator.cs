public class BSTIterator {
    private Stack<TreeNode> s = new Stack<TreeNode>();

    public BSTIterator(TreeNode root) {
        if (root != null)
            DFS(root);
    }
    
    public int Next() {
        if (!HasNext())
            return Int32.MinValue;        
        
        TreeNode cur = s.Pop();
        
        if (cur.right != null)
            DFS(cur.right);
        
        return cur.val;
    }
    
    public bool HasNext() {
        return s.Count != 0;
    }
    
    private void DFS(TreeNode node)
    {
        TreeNode cur = node;
        
        while (cur != null)
        {
            s.Push(cur);
            cur = cur.left;
        }
    }
}