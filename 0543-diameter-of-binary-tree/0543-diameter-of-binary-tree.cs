public class Solution {
    private int res = 0;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        DFS(root);
        
        return res;
    }
    
    private int DFS(TreeNode node)
    {
        if (node == null)
            return -1;
        
        int lMax = DFS(node.left),
            rMax = DFS(node.right);
        
        res = Math.Max(lMax + rMax + 2, res);
        
        return Math.Max(lMax, rMax) + 1;
    }
}