public class MyQueue {
    public Stack s1=new();
    public Stack s2=new();
    public MyQueue() {
     Stack s1=new();
     Stack s2=new();
    }
    
    public void Push(int x) {
        while(s1.Count > 0){
            s2.Push(s1.Pop());
        }
        s1.Push(x);
        while(s2.Count >0){
            s1.Push(s2.Pop());
        }
    }
    
    public int Pop() {
        return (int)s1.Pop();
    }
    
    public int Peek() {
        return (int)s1.Peek();
    }
    
    public bool Empty() {
        return s1.Count==0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */