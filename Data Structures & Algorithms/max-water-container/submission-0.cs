public class Solution {
    public int MaxArea(int[] heights) {

        var i = 0;
        var j = heights.Length - 1;

        var maxArea = 0;
        while (i < j) {
            var width = j - i;
            var height = heights[i] < heights[j] ? heights[i] : heights[j];
            var currArea = width * height;

            maxArea = maxArea > currArea ? maxArea : currArea;

            if (heights[i] > heights[j]) {
                j--;
            } else {
                i++;
            }
        }

        return maxArea;
    }
}
