/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    bool hasCycle(ListNode *head) {
        map<ListNode*,bool> visited;
        while(true){
            if(head==NULL)
                return false;
            if(visited[head])
                return true;
            visited[head]=true;
            head=head->next;
        }
    }
};