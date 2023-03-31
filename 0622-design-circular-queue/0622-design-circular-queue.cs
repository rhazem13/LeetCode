public class MyCircularQueue {
    private int curCount = 0,
                head = 0,
                tail = -1;
    private int[] _internal = null;
    
    public MyCircularQueue(int k) {
        _internal = new int[k];
    }
    
    public bool EnQueue(int value) {
        if (IsFull())
            return false;
        
        tail = (tail + 1) % _internal.Length;
        _internal[tail] = value;
        
        curCount++;
        
        return true;
    }
    
    public bool DeQueue() {
        if (IsEmpty())
            return false;
        
        head = (head + 1) % _internal.Length;
        curCount--;
        
        return true;
    }
    
    public int Front() {
        return IsEmpty() ? -1 : _internal[head];
    }
    
    public int Rear() {
        return IsEmpty() ? -1 : _internal[tail];
    }
    
    public bool IsEmpty() {
        return curCount == 0;
    }
    
    public bool IsFull() {
        return curCount ==_internal.Length;
    }
}