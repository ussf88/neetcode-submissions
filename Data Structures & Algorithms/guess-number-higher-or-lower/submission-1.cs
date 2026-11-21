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
        int left =1,right=n;
        int middle=left+(right-left)/2;
        int rez  = guess(middle);

        while(rez!=0){
            if(rez==-1) right=middle-1;
            else left=middle+1;
            middle=left+(right-left)/2;
            rez  = guess(middle);
        }
        return middle;
    }
}