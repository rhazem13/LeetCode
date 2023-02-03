public class Solution {
    private bool pacific = false,
                 atlantic = false;
    
    public IList<IList<int>> PacificAtlantic(int[][] matrix) {
        if (matrix == null || matrix.Length == 0)
            return new List<IList<int>>();
        
        IList<IList<int>> res = new List<IList<int>>();
        
        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[0].Length; j++)
            {
                DFS(matrix, i, j, new bool[matrix.Length, matrix[0].Length]);
                
                if (pacific && atlantic)
                    res.Add(new List<int>() { i, j });
                
                pacific = false;
                atlantic = false;
            }
        
        return res;
    }
    
    private void DFS(int[][] matrix, int i, int j, bool[,] visited)
    {
        visited[i, j] = true;
        
        if (i == 0 || j == 0)
            pacific = true;
        
        if (i == matrix.Length - 1 || j == matrix[0].Length - 1)
            atlantic = true;
        
        if (i - 1 > -1 && !visited[i - 1, j] && matrix[i - 1][j] <= matrix[i][j])
            DFS(matrix, i - 1, j, visited);
        
        if (j - 1 > -1 && !visited[i, j - 1] && matrix[i][j - 1] <= matrix[i][j])
            DFS(matrix, i, j - 1, visited);
        
        if (i + 1 < matrix.Length && !visited[i + 1, j] && matrix[i + 1][j] <= matrix[i][j])
            DFS(matrix, i + 1, j, visited);
        
        if (j + 1 < matrix[0].Length && !visited[i, j + 1] && matrix[i][j + 1] <= matrix[i][j])
            DFS(matrix, i, j + 1, visited);
    }
}