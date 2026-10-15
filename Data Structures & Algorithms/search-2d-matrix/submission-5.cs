public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        int left = 0;
        int right = n * m - 1;
        while (left <= right) {
            int middle = left + (right - left) / 2;
            int middleRow = middle / m;
            int middleCol = middle % m;
            if (matrix[middleRow][middleCol] > target) {
                right = middle - 1;
                continue;
            }
            if (matrix[middleRow][middleCol] < target) {
                left = middle + 1;

            } else
                return true;
        }

        return false;
    }
}