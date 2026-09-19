public class Solution {
    public int MajorityElement(int[] nums) {
        var n = nums.Length;
        Dictionary<int, int> occ = [];

        foreach(var el in nums) {
            occ[el] = occ.GetValueOrDefault(el) + 1;
            if (occ[el] > (n/2)) {
                return el;
            }
        }

        return 0; 
    }
}