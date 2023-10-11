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
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        ListNode cur=head;
        while(cur.next!=null){
            ListNode newNode=new ListNode(gcd(cur.val,cur.next.val));
            newNode.next=cur.next;
            cur.next=newNode;
            cur=cur.next.next;
        }
        return head;
    }
    public int gcd(int a,int b){
        if(b==0) return a;
        return gcd(b,a%b);
    }

}