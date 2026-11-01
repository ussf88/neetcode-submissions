public class Solution {
    public int MySqrt(int x) {
        if (x == 1 || x == 0)
            return x;
        long left = 1;
        long right = x - 1;
        long middle = 0;
        long max = 0;
        while (left <= right) {
            middle = left + (right - left) / 2;
            if (middle * middle > x)
                right = middle - 1;
            else if (middle * middle < x) {
                max = Math.Max(middle, max);
                left = middle + 1;
            } else
                return (int)middle;
        }
        return (int)max;
    }
}