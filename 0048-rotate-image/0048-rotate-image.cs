public class Solution {
    public void Rotate(int[][] matrix) {
        if (matrix == null || matrix.Length == 0)
            return;
        
        for (int i = 0; i < matrix.Length - 1; i++)
            for (int j = i + 1; j < matrix[0].Length; j++)
            {
                matrix[i][j] += matrix[j][i];
                matrix[j][i] = matrix[i][j] - matrix[j][i];
                matrix[i][j] -= matrix[j][i];
            }
        
        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[0].Length / 2; j++)
            {
                matrix[i][j] += matrix[i][matrix[0].Length - 1 - j];
                matrix[i][matrix[0].Length - 1 - j] = matrix[i][j] - matrix[i][matrix[0].Length - 1 - j];
                matrix[i][j] -= matrix[i][matrix[0].Length - 1 - j];
            }
    }
}