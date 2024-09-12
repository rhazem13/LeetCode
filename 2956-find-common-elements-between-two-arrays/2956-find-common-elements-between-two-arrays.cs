public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        int[] answers = new int[2];
        answers[0]=0;
        answers[1]=0;
        for(int i=0;i<nums1.Length;i++){
            for(int j=0;j<nums2.Length;j++){
                if(nums1[i]==nums2[j]){
                    answers[0]++;
                    break;
                }
            }
        }
        for(int i=0;i<nums2.Length;i++){
            for(int j=0;j<nums1.Length;j++){
                if(nums2[i]==nums1[j]){
                    answers[1]++;
                    break;
                }
            }
        }
        return answers;
    }
}