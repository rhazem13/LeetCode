/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    bool evaluateTree(TreeNode* root) {
        if(root->val>1){
        if(root->left->val>1){
            root->left->val=evaluateTree(root->left);
        }
        if(root->right->val>1){
            root->right->val=evaluateTree(root->right);
        }}
        if(root->val==2){

            if(root->left->val==1 || root->right->val==1){
                return 1;
            }
            return 0;
        }
        else if(root->val==3){
            if(root->left->val==1&&root->right->val==1){
                return 1;
            }
            return 0;
        }
        else {
            return root->val;
        }
    }
};