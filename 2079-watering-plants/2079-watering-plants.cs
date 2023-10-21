public class Solution {
    public int WateringPlants(int[] plants, int capacity) {
        int res=0,i=0,currentCap=capacity;
        // o(n) i guess
        while(i<plants.Length){
            if(currentCap<plants[i]){
                currentCap=capacity-plants[i];
                res+=2*i+1;
                i++;
            }
            else{
                currentCap-=plants[i];
                i++;
                res++;
            }
        }
        return res;
    }
}