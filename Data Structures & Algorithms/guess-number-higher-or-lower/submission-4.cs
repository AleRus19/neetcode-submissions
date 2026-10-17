/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {

        int left = 1;
        int rigth = n;
    
        var pick = left + (rigth - left) / 2;

        while(true) {
            var res = guess(pick);
            if (res == 0) {
                return pick;
            } else if (res == -1) {
                rigth = pick - 1;
                pick = (rigth - left) / 2;
            } else {
                left = pick + 1;
                pick = left + (rigth - left) / 2;
            }
        }
    }
}