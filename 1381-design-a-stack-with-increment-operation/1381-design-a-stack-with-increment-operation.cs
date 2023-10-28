public class CustomStack {
    int[] stack;
    int i;
    public CustomStack(int maxSize) {
        stack = new int[maxSize];
        i=-1;
    }
    
    public void Push(int x) {
        if(i<stack.Length-1){
            i++;
            stack[i]=x;
        }
    }
    
    public int Pop() {
        if(i>-1)
            return stack[i--];
        else return -1;
    }
    
    public void Increment(int k, int val) {
        int j=0;
        while(j<k&&j<stack.Length){
            stack[j]+=val;
            j++;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */