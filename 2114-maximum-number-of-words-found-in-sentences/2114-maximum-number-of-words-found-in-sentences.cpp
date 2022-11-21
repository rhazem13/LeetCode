class Solution {
public:
    int mostWordsFound(vector<string>& sentences) {
        int spacescount=0;
        int maximumWords=0;
        for(int i=0;i<sentences.size();i++){
            spacescount=0;
            for(int j=0;j<sentences[i].size();j++){
                if(sentences[i][j]==' '){
                    spacescount++;
                }
            }
            if(spacescount+1>maximumWords){
                maximumWords=spacescount+1;
            }
        }
        return maximumWords;
    }
};