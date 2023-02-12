public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int n = isConnected.Length;
        int count = 0;
        bool[] visited = new bool[n];
        for(int i=0;i<n;i++){
            if(!visited[i]){
                count++;
                dfs(isConnected,visited,i,n);
            }
        }
        return count;
    }
    private void dfs(int[][] isConnected, bool[] visited, int cur,int n){
        visited[cur]=true;
        for(int i=0;i<n;i++){
            if(isConnected[cur][i]==1&&!visited[i]){
                dfs(isConnected, visited, i, n);
            }
        }
    }
}