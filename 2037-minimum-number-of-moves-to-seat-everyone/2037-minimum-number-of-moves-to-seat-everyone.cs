public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        int ans=0;
        // sort both arrays?
        Array.Sort(seats);
        Array.Sort(students);
        for(int i=0;i<seats.Length;i++){
            ans+= Math.Abs(students[i]-seats[i]);
        }
        return ans;
    }
}