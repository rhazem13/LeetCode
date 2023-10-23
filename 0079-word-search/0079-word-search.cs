public class Solution {
    bool found;
    public void traverse(char[][] board, string word, int i, int j, int wordindex){
        if(wordindex>=word.Length || wordindex<0){
            found=true;
            return;
        }
        if(i>=board.Length || j>=board[0].Length || i<0 || j<0) return;
        if(board[i][j]!=word[wordindex])return;
        wordindex++;
        char original = board[i][j];
        board[i][j]='*';
        traverse(board,word,i+1,j,wordindex); if(found) return;
        traverse(board,word,i-1,j,wordindex); if(found) return;
        traverse(board,word,i,j+1,wordindex); if(found) return;
        traverse(board,word,i,j-1,wordindex); if(found) return;
        board[i][j]=original;
    }
    public bool Exist(char[][] board, string word) {
        found=false;
        for(int i=0;i<board.Length;i++){
            for(int j=0;j<board[0].Length;j++){
                if(board[i][j]==word[0]){
                    traverse(board,word,i,j,0);
                }
            }
        }
        return found;
    }
}