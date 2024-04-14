public class Solution {
    public int[] ProcessQueries(int[] queries, int m) {
        // Initialize an array to store the positions of each element in the permutation
        int[] positions = new int[m + 1];
        for (int i = 1; i <= m; i++) {
            positions[i] = i - 1;
        }
        
        int[] answer = new int[queries.Length];
        
        // Iterate through queries
        for (int i = 0; i < queries.Length; i++) {
            int cur = queries[i];
            int curIdx = positions[cur];
            answer[i] = curIdx;
            
            // Update positions of elements in the permutation
            for (int j = 1; j <= m; j++) {
                if (positions[j] < curIdx) {
                    positions[j]++;
                }
            }
            
            // Move the current element to the beginning
            positions[cur] = 0;
        }
        
        return answer;
    }
}
