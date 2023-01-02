public class Solution {
    public int[][] UpdateMatrix(int[][] matrix) {
        int[] dx = new int[] { 1, -1, 0, 0 },
              dy = new int[] { 0, 0, 1, -1 };
        int[][] result = new int[matrix.Length][];
        
        for (int i = 0; i < result.Length; i++)
            result[i] = new int[matrix[0].Length];
        
        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[0].Length; j++)
                if (matrix[i][j] != 0)
                {
                    Queue<int[]> queue = new Queue<int[]>();
                    bool[,] visited = new bool[matrix.Length, matrix[0].Length];
                    int distance = -1;
                    
                    queue.Enqueue(new int[] { i, j });
                    visited[i, j] = true;
                    
                    while (queue.Count > 0)
                    {
                        int count = queue.Count;                        
                        bool found = false;
                        
                        distance++;
                        
                        while (count > 0)
                        {
                            int[] cur = queue.Dequeue();
                            
                            if (matrix[cur[0]][cur[1]] == 0)
                            {
                                result[i][j] = distance;
                                found = true;
                                
                                break;
                            }
                            else
                                for (int k = 0; k < 4; k++)
                                {
                                    int newX = cur[0] + dx[k],
                                        newY = cur[1] + dy[k];
                                    
                                    if (newX > -1 && newX < matrix.Length && newY > -1 && newY < matrix[0].Length && !visited[newX, newY])
                                    {
                                        queue.Enqueue(new int[] { newX, newY });
                                        visited[newX, newY] = true;
                                    }
                                }
                            
                            count--;
                        }
                        
                        if (found)
                            break;
                    }
                }
        
        return result;
    }
}