
public class Solution {
    public bool found;
    public void tryConnecting(ListNode head,TreeNode root){
        if(head==null){
            found=true;
            return;
        }
        if(root!=null){
            if(root.val==head.val){
                tryConnecting(head.next,root.left);
                tryConnecting(head.next,root.right);
            }
        }
    }
    public void dfs(ListNode head,TreeNode root){
        if(root!=null){
            if(root.val==head.val){
                tryConnecting(head,root);
            }
            dfs(head,root.left);
            dfs(head,root.right);
        }
    }
    public bool IsSubPath(ListNode head, TreeNode root) {
        found=false;
        dfs(head,root);
        return found;
    }
}