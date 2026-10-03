public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                var j = i + 1;
                while(j < nums.Length && nums[j] == 1) {
                    j++;
                }
                var m = j - i;
                if (max < m) {
                    max = m;
                }
            }
        }

        return max;
    }
}