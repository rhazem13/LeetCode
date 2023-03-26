public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1.val == 0)
            return l2;
        else if (l2.val == 0)
            return l1;
        
        Stack<int> s1 = new Stack<int>(),
                   s2 = new Stack<int>();
        
        while (l1 != null)
        {
            s1.Push(l1.val);
            l1 = l1.next;
        }
        
        while (l2 != null)
        {
            s2.Push(l2.val);
            l2 = l2.next;
        }
        
        Stack<int> s3 = Cal(s1, s2);
        
        ListNode d = new ListNode(),
                 cur = d;
        
        while (s3.Count > 0)
        {
            ListNode n = new ListNode(s3.Pop());
            cur.next = n;
            cur = cur.next;
        }
        
        return d.next;
    }
    
    private Stack<int> Cal(Stack<int> s1, Stack<int> s2)
    {
        int carrier = 0;
        Stack<int> s3 = new Stack<int>();
        
        while (s1.Count > 0 && s2.Count > 0)
        {
            int i = s1.Pop() + s2.Pop() + carrier;
            carrier = i / 10;
            i %= 10;
            
            s3.Push(i);
        }
        
        while (s1.Count > 0)
        {
            int i = s1.Pop() + carrier;
            carrier = i / 10;
            i %= 10;
            
            s3.Push(i);
        }
        
        while (s2.Count > 0)
        {
            int i = s2.Pop() + carrier;
            carrier = i / 10;
            i %= 10;
            
            s3.Push(i);
        }
        
        if (carrier > 0)
            s3.Push(carrier);
        
        return s3;
    }
}