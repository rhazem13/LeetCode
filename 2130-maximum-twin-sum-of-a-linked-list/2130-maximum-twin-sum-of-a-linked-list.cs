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
    public int PairSum(ListNode head) {
        // make stack until we reach middle then keep pop from stack !
        Stack<int> stack=new();
        int max=-1;
        // get list length
        int length=0;
        ListNode tmp = head;
        while(tmp!=null){
            length++;
            tmp=tmp.next;
        }
        // iterate until mid
        tmp=head;
        length/=2;
        int curtwin;
        while(tmp!=null){
            if(length>0){
                length--;
                stack.Push(tmp.val);
                tmp=tmp.next;
            }
            else{
                curtwin=stack.Pop();
                max=Math.Max(max,curtwin+tmp.val);
                tmp=tmp.next;
            }
        }
        return max;
    }
}