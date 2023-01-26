public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        IList<int> res = new List<int>();
        int i = 0,
            j = -1;
        bool[,] visited = new bool[matrix.Length, matrix[0].Length];
        int[] dx = new int[] { 0, 1, 0, -1 },
              dy = new int[] { 1, 0, -1, 0 };
        
        while (res.Count != matrix.Length * matrix[0].Length)
        {
            for (int k = 0; k < 4; k++)
            {
                i += dx[k];
                j += dy[k];
                
                while (i > -1 && i < matrix.Length && j > -1 && j < matrix[0].Length && !visited[i, j])
                {
                    res.Add(matrix[i][j]);
                    visited[i, j] = true;

                    i += dx[k];
                    j += dy[k];
                }
                
                i -= dx[k];
                j -= dy[k];
            }
        }
        
        return res;
    }
}