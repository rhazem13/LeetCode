public class MinStack {
    Stack<(int,int)> stack=null;    
    
    public MinStack() {
        stack=new Stack<(int, int)>();
    }
    
    public void Push(int x) {
        stack.Push((x, stack.Count==0 ? x : stack.Peek().Item2 > x ? x : stack.Peek().Item2));
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().Item1;
    }
    
    public int GetMin() {
        return stack.Peek().Item2;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */