public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        var current = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                current++;
            } else {
                if (current > max) {
                    max = current;
                }
                current = 0;
            }
        }
        return current > max ? current : max;
    }
}