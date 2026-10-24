public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        var i = 0;
        var j = nums.Length - 1;

        while (i <= j) {
            while(i <= j && nums[i] != val) {
                i++;
            }

            while(i <= j && nums[j] == val) {
                j--;
            }
            if (i < j) {
                nums[i] = nums[j];
                nums[j] = val;
            }
        }

        return i;
    }
}