public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        IList<IList<int>> ans=new List<IList<int>>();
        if(root==null)
            return ans;
        Queue<Node> q = new();
        q.Enqueue(root);
        while(q.Count != 0){
            List<int> tmp = new();
            int count = q.Count;
            while(count>0){
                Node node = q.Dequeue();
                foreach(var child in node.children)
                    q.Enqueue(child);
                tmp.Add(node.val);
                count--;
            }
            ans.Add(tmp);
        }
        return ans;
    }
}