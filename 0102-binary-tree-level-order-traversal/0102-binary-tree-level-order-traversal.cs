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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> ans=new List<IList<int>>();
        if(root!=null){
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while(q.Count!=0){
                List<int> tmp=new List<int>();
                int count=q.Count;
                for(int i=0;i<count;i++){
                    TreeNode x = q.Peek();
                    q.Dequeue();
                    tmp.Add(x.val);
                    if(x.left!=null){
                        q.Enqueue(x.left);
                    }
                    if(x.right!=null){
                        q.Enqueue(x.right);
                    }
                }
                ans.Add(tmp);
            }
        }
        return ans;
    }
}