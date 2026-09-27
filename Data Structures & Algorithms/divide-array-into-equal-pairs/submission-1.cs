public class Solution {
    public bool DivideArray(int[] nums) {
        var dict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            dict[nums[i]] = dict.GetValueOrDefault(nums[i]) + 1;
        }

        foreach (var kv in dict) {
            if (kv.Value % 2 != 0) {
                return false;
            }
        }

        return true;
    }
}