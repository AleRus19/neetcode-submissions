public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;
        foreach (var d in details) {
            int f = d[11] - '0';
            int s = d[12] - '0';
            if ((f > 6) || (f == 6 && s > 0)) {
                count++;
            }
        }

        return count;
    }
}