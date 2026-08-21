public class Solution {
    public int MaxProfit(int[] prices) {
        var i = 0;
        var j = 1;
        var n = prices.Length;
        if (n == 1) {
            return 0;
        }

        var profit = 0;

        while (j < n) {
            var currProfit = prices[j] - prices[i];

            if (currProfit > profit) {
                profit = currProfit;
            }

            if (prices[j] <= prices[i]) {
                i = j;
                j++;
            } else {
                j++;
            }
        }

        return profit;
    }
}
