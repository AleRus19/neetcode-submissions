public class Solution {
    public bool DivideArray(int[] nums) {
        var set = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++) {
            if (set.Contains(nums[i])) {
                set.Remove(nums[i]);
            } else {
                set.Add(nums[i]);
            }
        }

        if (set.Count == 0) {
            return true;
        }

        return false;
    }
}