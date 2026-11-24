public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        int n = asteroids.Length;
        int i = 0;
        var stack = new Stack<int>();
        while (i < n) {
            bool colision = stack.Count > 0 && stack.Peek() > 0 && asteroids[i] < 0;
            if (colision) {
                var peek = stack.Peek();
                if (peek <= -asteroids[i]) stack.Pop();
                if(peek >= -asteroids[i]) i++;
                continue;
            }

            // no collision
            stack.Push(asteroids[i]);
            i++;
        }
        return stack.Reverse().ToArray();
    }
}