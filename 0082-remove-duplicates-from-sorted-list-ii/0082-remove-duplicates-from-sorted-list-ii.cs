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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head==null)return head;
        // make arr of node . val and init with -1
        // fill the array with count of each val
        // travese linked list and if found the val in the arr skip it 
        int[] count = new int[202];
        ListNode cur = head, prev;
        while(cur!=null){
            count[cur.val+100]++;
            cur=cur.next;
        }
        cur=head;
        // edge case if first val is duplicated
        while(count[head.val+100]>1){
        head=head.next;
        if(head==null)
            return head;
        }
        cur=head;
        prev=cur;
        while(cur!=null){
            if(count[cur.val+100]>1){
                prev.next=cur.next;
                cur=prev.next;
            } else {
                prev=cur;
                cur=cur.next;
            }
        }
        return head;
    }
}