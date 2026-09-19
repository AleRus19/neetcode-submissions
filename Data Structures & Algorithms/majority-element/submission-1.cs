public class Solution {
    public int MajorityElement(int[] nums) {

        var candidate = nums[0];
        var count = 0;
        foreach(var el in nums) {
            if (count == 0 && el != candidate) {
                candidate = el;
                count++;
            } else if (el != candidate) {
                count--;
            } else {
                count++;
            }
            
        }

        return candidate;
    }
}