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
    public ListNode MergeNodes(ListNode head) {
        ListNode ans=new();
        ListNode prev=new();
        ListNode result=ans;
        int tmp;
        while(head!=null){
            if(head.val==0){
                tmp=0;
                head=head.next;
                while(head.val!=0 ){
                    tmp+=head.val;
                    head=head.next;
                }
                ans.val=tmp;
                ans.next=new ListNode();
                prev=ans;
                ans=ans.next;
            }
            if(head.next==null)
                break;
        }
        prev.next=null;
        return result;
    }
}