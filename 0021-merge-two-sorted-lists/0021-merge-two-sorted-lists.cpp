/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* mergeTwoLists(ListNode* list1, ListNode* list2) {
     ListNode* list3=new ListNode();
     ListNode* ans=list3;
        while(list1!=NULL||list2!=NULL){
            if(list1==NULL){
                list3->next=list2;
                break;
            }
            else if(list2==NULL){
                list3->next=list1;
                break;
            }
            else{
                if(list1->val<list2->val){
                    ListNode* tmp = list1;
                    list1=list1->next;
                    tmp->next=list3->next;
                    list3->next=tmp;
                    list3=list3->next;
                }
                else{
                    ListNode* tmp = list2;
                    list2=list2->next;
                    tmp->next=list3->next;
                    list3->next=tmp;
                    list3=list3->next;
                }
            }
        }
         return ans->next;
    
}};