public class Solution {
    public IList<int> Preorder(Node root) {
        IList<int> preOrder = new List<int>();
        Stack<Node> s = new Stack<Node>();
        Node tmp;

        s.Push(root);
        while (s.TryPop(out tmp) && tmp != null)
        {
            preOrder.Add(tmp.val);
            for (int i = tmp.children.Count - 1; i >= 0; i--)
            {
                s.Push(tmp.children[i]);
            }
        }
        return preOrder;
    }
}