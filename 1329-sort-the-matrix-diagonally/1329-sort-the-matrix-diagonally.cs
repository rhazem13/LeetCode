public class Solution
{
    public int[][] DiagonalSort(int[][] mat)
    {
        int m = mat.Length;
        int n = mat[0].Length;
        int diag = m+n-1;

        int p = m;
        int q = 0;

        for(int k=0; k<diag; k++)
        {   
            int index = 0;
            List<int> tempList =  new();
            if(p > 0)
            {
                p--;
                
                for(int i=p, j=0; i<m && j<n; i++, j++)
                    tempList.Add(mat[i][j]);

                tempList.Sort();
                
                for(int i=p, j=0; i<m && j<n; i++, j++)
                    mat[i][j] = tempList[index++];
            }
            else
            {
                q++;

                for(int i=0, j=q; i<m && j<n; i++, j++)
                    tempList.Add(mat[i][j]);

                tempList.Sort();

                for(int i=0, j=q; i<m && j<n; i++, j++)
                    mat[i][j] = tempList[index++];
            }
        }

        return mat;
    }
}