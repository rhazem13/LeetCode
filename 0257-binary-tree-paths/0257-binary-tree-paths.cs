public class Solution {
    public List<string> ans;
    public IList<string> BinaryTreePaths(TreeNode root) {
        ans=new();
        if(root.left==null&&root.right==null){
                ans.Add(root.val.ToString());
                return ans;
            }
        StringBuilder sb=new();
        dfs(root,sb);
        return ans;
    }
    public void dfs(TreeNode root,StringBuilder sb){
        if(root!=null){
            sb.Append(root.val);
            if(root.left==null&&root.right==null){
                ans.Add(sb.ToString());
            }
            else{
            sb.Append("->");
            }
            StringBuilder sbl=new();
            StringBuilder sbr=new();
            sbl.Append(sb.ToString());
            sbr.Append(sb.ToString());
            dfs(root.left,sbl);
            dfs(root.right,sbr);
        }
    }
}