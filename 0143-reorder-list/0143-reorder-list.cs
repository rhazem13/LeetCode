public class Solution {
    public void ReorderList(ListNode head) {
        if (head==null)
            return;
        Stack<ListNode> s = new();
        ListNode tmp = head;
        int len=0;
        while(tmp!=null){
            len++;
            s.Push(tmp);
            tmp=tmp.next;
        }
        ListNode cur = head;
        for (int i=1;i<=len/2;i++){
            ListNode temp = cur.next;
            ListNode x = s.Pop();
            cur.next = x;
            x.next = temp;
            cur=temp;
        }
        cur.next=null;
    }
}