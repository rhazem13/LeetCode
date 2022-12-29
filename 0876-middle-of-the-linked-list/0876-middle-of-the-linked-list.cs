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
    public ListNode MiddleNode(ListNode head) {
        ListNode tmp=head;
        int n=0;
        while(tmp!=null){
            tmp=tmp.next;
            n++;
        }
        n/=2;
        while(n>0){
            head=head.next;
            n--;
        }
        return head;
    }
}