public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        int n = asteroids.Length;
        var t = asteroids;
        int i = 0;
        var stack = new Stack<int>();
        while (i < n) {
            bool colision = stack.Count > 0 && stack.Peek() > 0 && t[i] < 0;
            if (colision) {
                // handle collision
                if (stack.Peek() == -t[i]) {
                    stack.Pop();
                    i++;
                } else if (stack.Peek() < -t[i]) {
                    stack.Pop();
                } else
                    i++;

                continue;
            }
            // no collision
            stack.Push(t[i]);
            i++;
        }
        return stack.Count == 0 ? [] : stack.Reverse().ToArray();
    }

    private bool SameSign(int a, int b) => (a ^ b) >= 0;
}