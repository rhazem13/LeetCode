public class Solution {
    public int helper(Node root, int cur){
        if(root!=null){
            if(root.children.Count==0)
                return cur;
            int tmp,max=-1;
            for(int i=0;i<root.children.Count;i++){
                tmp=helper(root.children[i],cur+1);
                if(tmp>max)
                    max=tmp;
            }
            return max;
        } else
            return cur;
    }
    public int MaxDepth(Node root) {
        return root==null?0: helper(root,1);
    }
}