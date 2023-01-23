public class Solution {
    public int ArraySign(int[] nums) {
        var result = 1;
	foreach (var num in nums) {
		if (num == 0) {
			return 0;
		}
		result *= num > 0 ? 1 : -1;
	}
	return result;
    }
}