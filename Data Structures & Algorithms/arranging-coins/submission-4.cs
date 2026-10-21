public class Solution {
    public int ArrangeCoins(int n) {
        var left = 1;
        var rigth = n;

        while (left <= rigth) {
            var m = left + (rigth - left) / 2;

            var result = (long)m * (m + 1) / 2;
        
            if (result == n) {
                return m;
            } else if (result < n) {
                left = m + 1;
            } else {
                rigth = m - 1;
            }
        }

        return rigth; 
    }
}