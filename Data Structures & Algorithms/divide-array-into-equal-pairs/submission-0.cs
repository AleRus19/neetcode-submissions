public class Solution {
    public bool DivideArray(int[] nums) {
        List<int>[] buckets = new List<int>[500];

        for(int i = 0; i < buckets.Length; i++) {
            buckets[i] = new List<int>(nums.Length);
        }

        for(int i = 0; i < nums.Length; i++) {
            buckets[nums[i]-1].Add(nums[i]);
        }

        for (int i = 0; i <  buckets.Length; i++) {
            if (buckets[i].Count % 2 != 0) {
                return false;
            }
        }

        return true;
    }
}