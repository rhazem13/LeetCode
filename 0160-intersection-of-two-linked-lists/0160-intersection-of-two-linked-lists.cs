/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        HashSet<ListNode> set=new();
        while(headA!=null || headB!=null){
            if(headA!=null){
                if(set.Contains(headA))
                    return headA;
                set.Add(headA);
                headA=headA.next;
            }
            if(headB!=null){
                if(set.Contains(headB))
                    return headB;
                set.Add(headB);
                headB=headB.next;
            }
        }
        return null;
    }
}