/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(k==0 || head==null) return head;
        // get length
        ListNode tmp = head;
        int length=1;
        while(tmp.next!=null){
            tmp=tmp.next;
            length++;
        }
        if( k%length==0) return head;
        // if k > lenth subtract using absolute value
        while(k>=length)
            k=Math.Abs(length-k);
        ListNode lastprev=head,last=head;
        for(int i=0;i<length-k;i++){
            lastprev=last;
            last=last.next;
        }
        tmp=last;
        lastprev.next=null;
        while(last.next!=null)
            last=last.next;
        last.next=head;
        head=tmp;
        return head;
    }
}