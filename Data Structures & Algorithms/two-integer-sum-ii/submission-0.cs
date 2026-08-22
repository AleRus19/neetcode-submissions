public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var i = 0;
        var j = numbers.Length - 1;

        while (i < j) {
            var currSum = numbers[i] + numbers[j];
            if (currSum == target) {
                return [i + 1, j + 1] ;
            }

            else if (currSum < target) {
                i++;
            } else {
                j--;
            }
        }

        return [i + 1, j + 1];
    }
}
