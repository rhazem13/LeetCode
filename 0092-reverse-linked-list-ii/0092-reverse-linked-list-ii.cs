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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        // using stack i can do it one pass
        ListNode tmp = head;
        ListNode nodeLeft=null;
        Stack<int> stack=new();
        int count=1;
        while(tmp!=null){
            if(count==left){
                nodeLeft=tmp;
            }
            if(count>=left){
                stack.Push(tmp.val);
            }
            if(count==right){
                while(stack.Count>0){
                    nodeLeft.val=stack.Pop();
                    nodeLeft=nodeLeft.next;
                }
                break;
            }
            tmp=tmp.next;
            count++;
        }
        return head;
    }
}