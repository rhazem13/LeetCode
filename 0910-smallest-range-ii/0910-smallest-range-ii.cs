public class Solution {
    public int SmallestRangeII(int[] A, int K) {
	int N = A.Length;
	Array.Sort(A);
	int ans = A[N-1] - A[0];

	for (int i = 0; i < A.Length - 1; ++i) {
		int a = A[i], b = A[i+1];
		int high = Math.Max(A[N-1] - K, a + K);
		int low = Math.Min(A[0] + K, b - K);
		ans = Math.Min(ans, high - low);
	}
	return ans;
}
}