public class Solution {
    public void Fill(int[][] image, int sr, int sc, int color,int baseColor){
        if(sr < image.Length && sr>=0 && sc>=0 && sc < image[0].Length){
            if(image[sr][sc]==baseColor){
                image[sr][sc]=color;
                Fill(image,sr+1,sc,color,baseColor);
                Fill(image,sr,sc+1,color,baseColor);
                Fill(image,sr-1,sc,color,baseColor);
                Fill(image,sr,sc-1,color,baseColor); 
            }
           
        }
    }
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(color!=image[sr][sc])
            Fill(image,sr,sc,color,image[sr][sc]);
        return image;
    }
}