public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        int l1 = 0, l2 = 0;
        int r1 = n - 1, r2 = m - 1;
        while (l1 < r1 || (l1 == r1 && l2 <= r2)) {
            int indexLeft = l1 * m + l2;
            int indexRight = r1 * m + r2;
            int middle = indexLeft + (indexRight - indexLeft) / 2;
            int middleRow = middle / m;
            int middleCol = middle % m;
            if (matrix[middleRow][middleCol] > target) {
                if (middleCol == 0) {
                    r1 = r1 - 1;
                    r2 = m - 1;
                } else {
                    r1 = middleRow;
                    r2 = middleCol - 1;
                }

            } else if (matrix[middleRow][middleCol] < target) {
                if (l2 == m - 1) {
                    l1 = l1 + 1;
                    l2 = 0;
                } else {
                    l1 = middleRow;
                    l2 = middleCol + 1;
                }

            } else
                return true;
        }

        return false;
    }
}