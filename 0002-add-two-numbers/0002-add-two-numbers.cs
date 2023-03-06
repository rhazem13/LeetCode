public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1 == null)
            return l2;
        else if (l2 == null)
            return l1;
        
        ListNode dummy = new ListNode(),
                 cur = dummy;
        Queue<int> q1 = new Queue<int>(),
                   q2 = new Queue<int>();
        int carrier = 0;
        
        while (l1 != null)
        {
            q1.Enqueue(l1.val);
            l1 = l1.next;
        }
        
        while (l2 != null)
        {
            q2.Enqueue(l2.val);
            l2 = l2.next;
        }
        
        while (q1.Count != 0 && q2.Count != 0)
        {
            int val = q1.Dequeue() + q2.Dequeue() + carrier;
            carrier = val / 10;
            val %= 10;
            
            cur.next = new ListNode(val);
            cur = cur.next;
        }
        
        Queue<int> q3 = q1.Count != 0 ? q1 : q2.Count != 0 ? q2 : new Queue<int>();
        
        while (q3.Count != 0)
        {
            int val = q3.Dequeue() + carrier;
            carrier = val / 10;
            val %= 10;
            
            cur.next = new ListNode(val);
            cur = cur.next;
        }
        
        if (carrier != 0)
            cur.next = new ListNode(carrier);
        
        return dummy.next;
    }
}