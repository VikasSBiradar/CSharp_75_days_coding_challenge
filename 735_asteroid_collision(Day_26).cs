public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();
    
        foreach (int asteroid in asteroids) {
            if (asteroid > 0) {
                stack.Push(asteroid);
            } else {
                while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid)) {
                    stack.Pop();
                }
                
                if (stack.Count == 0 || stack.Peek() < 0) {
                    stack.Push(asteroid);
                } else if (stack.Peek() == Math.Abs(asteroid)) {
                    stack.Pop();
                }
            }
        }
        
        int[] result = new int[stack.Count];
        for (int i = stack.Count - 1; i >= 0; i--) {
            result[i] = stack.Pop();
        }
        
        return result;
    }
}