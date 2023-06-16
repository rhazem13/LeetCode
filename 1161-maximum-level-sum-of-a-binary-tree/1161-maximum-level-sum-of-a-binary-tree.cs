public class Solution {
    public int MaxLevelSum(TreeNode root) {
        // n3ml Q w npush feh
        int maxsum=root.val;
        int maxLevel=1;
        int level=1;
        TreeNode cur=null;
        Queue<TreeNode> myQueue = new Queue<TreeNode>();
        myQueue.Enqueue(root);
        while(myQueue.Count>0){
            int currentLevelSum = 0;
            int n = myQueue.Count;
            while(n>0){
                cur = myQueue.Dequeue();
                currentLevelSum += cur.val;
                if(cur.left!=null){
                    myQueue.Enqueue(cur.left);
                }
                if(cur.right!=null){
                    myQueue.Enqueue(cur.right);
                }
                n--;
            }
            if(currentLevelSum>maxsum){
                maxsum=currentLevelSum;
                maxLevel=level;
            }
            level++;
        }
        return maxLevel;
    }
}