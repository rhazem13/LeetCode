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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int s=0;
        ListNode tmp=head;
        while(tmp!=null){
            tmp=tmp.next;
            s++;
        }
        s-=n;
        tmp=head;
        ListNode prev=head;
        if(s==0){
            return head.next;
        }
        while(s>0){
            prev=tmp;
            tmp=tmp.next;
            s--;
        }
        prev.next=tmp.next;
        return head;
        
    }
}