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
    ListNode *detectCycle(ListNode *head) {
        if(head==NULL){
            return NULL;
        }
        ListNode* looper=head;
        while(looper->next!=NULL){
            ListNode* tmp1=looper;
            ListNode* tmp2;
            int counter=10000;
            while(tmp1->next!=NULL && counter>0){
                counter--;
                if(tmp1->next==looper){
                    return tmp1->next;
                }
                tmp1=tmp1->next;
            }
            looper=looper->next;
        }
        return NULL;
    }
};