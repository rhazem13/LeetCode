class Solution {
public:
   void flood(vector<vector<int>>& image, int sr, int sc, int color,int srcColor,vector<vector<int>>& visited) {
    if (sr < image.size() && sc < image[0].size()) {
        if (image[sr][sc] == srcColor && visited[sr][sc] != -1) {
            image[sr][sc] = color;
            visited[sr][sc] = -1;
            flood(image, sr + 1, sc, color, srcColor, visited);
            flood(image, sr , sc - 1, color, srcColor, visited);
            flood(image, sr , sc + 1, color, srcColor, visited);
            flood(image, sr - 1, sc , color, srcColor, visited);
        }
    }
}
    vector<vector<int>> floodFill(vector<vector<int>>& image, int sr, int sc, int color) {
    int srcColor = image[sr][sc];
    vector<vector<int>> visited(image);
    flood(image, sr, sc, color, srcColor,visited);
    return image;}
};