public class Solution {
    public int[] MinOperations(string boxes) {
        int[] result = new int[boxes.Length];
        int leftBalls=0, rightBalls=0;
        for(int i=1;i<boxes.Length;i++){
            if(boxes[i]=='1'){
                rightBalls+=1;
                result[0]+=i;
            }
        }
        for(int i=1;i<boxes.Length;i++){
            if(boxes[i-1]=='1')
                leftBalls++;
            result[i]=result[i-1]+leftBalls-rightBalls;
            if(boxes[i]=='1')
                rightBalls--;
        }
        return result;
    }
}