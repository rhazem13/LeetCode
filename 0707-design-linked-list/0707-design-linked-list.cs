public class MyLinkedList 
{
    private Node head;
    int count = 0;
    
    public int Get(int index) 
    {
        var node = GetNode(index);
        return node == null ? -1 : node.val;
    }
    
    public Node GetNode(int index) 
    {
        if(index >= count) 
            return null;
        var curr = head;
        for(int i = 0; i < index; i++)
            curr = curr.next;
        
        return curr;
    }
    
    public void AddAtHead(int val) 
    {
        var newNode = new Node(val);
        newNode.next = head;
        head = newNode;
        count++;
    }
    
    public void AddAtTail(int val) 
    {
        if(head == null)
        {
            AddAtHead(val);
            return;
        }
        
        var node = GetNode(count - 1);
        node.next = new Node(val);
        count++;
    }
    
    public void AddAtIndex(int index, int val) 
    {
        if(index > count)
            return;
       if(index == 0)
       {
           AddAtHead(val);
           return;
       }
        var node = GetNode(index - 1);
        var newNode = new Node(val);
        newNode.next = node.next;
        node.next = newNode;
        count++;
    }
    
    public void DeleteAtIndex(int index) 
    {
        if(count == 0)
            return;
        
        if(index < count && index >= 0)
        {
            if(index == 0)
                head = head.next;
            else
            {
                var node = GetNode(index - 1);
                node.next = node.next.next;
            }
            
            count--;
        }
    }
}

public class Node
{
    public int val;
    public Node next;
    public Node(int n)
    {
        val = n; 
    }
}