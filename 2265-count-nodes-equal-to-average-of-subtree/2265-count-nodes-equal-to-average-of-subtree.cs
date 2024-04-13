public class Solution {
    public int count = 0;

    public (int sum, int count) SumSub(TreeNode root) {
        if (root == null) return (0, 0);

        var left = SumSub(root.left);
        var right = SumSub(root.right);

        int sum = root.val + left.sum + right.sum;
        int totalCount = 1 + left.count + right.count;

        if (root.val == sum / totalCount) {
            count++;
        }

        return (sum, totalCount);
    }

    public int AverageOfSubtree(TreeNode root) {
        SumSub(root);
        return count;
    }
}
