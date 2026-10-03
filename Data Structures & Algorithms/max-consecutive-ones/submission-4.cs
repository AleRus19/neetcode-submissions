public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        var i = 0;
        var j = i + 1;
        var n = nums.Length;
       
        while (true) {
            while ( i < n && nums[i] == 0) {
                i++;
            }
            if (i >= n) {
                return max;
            }
            j = i + 1;
            if (j >= n) {
                if (j - i > max) {
                    max = j - i;
                }
                return max;
            }

            while(j < n && nums[j] == 1) {
                j++;
            }

            if (j - i > max) {
                max = j - i;
            }
            i = j + 1;
        }

        return max;
    }
}