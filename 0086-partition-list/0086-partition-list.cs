
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode before = new ListNode(0);
        ListNode after = new ListNode(0);
        ListNode before_curr = before;
        ListNode after_curr = after;
        while(head!=null){
            if(head.val<x){
                before_curr.next=head;
                before_curr=head;
            }
            else if(head.val>=x){
                after_curr.next=head;
                after_curr=head;
            }
            head=head.next;
        }
        after_curr.next=null;
        before_curr.next=after.next;
        return before.next;
    }
}