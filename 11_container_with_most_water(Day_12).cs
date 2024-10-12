public class Solution {
    public int MaxArea(int[] height) {
        int max = Int32.MinValue;
        int i = 0; 
        int j = height.Length - 1;
        while(i < j){
            int min = Math.Min(height[i],height[j]);
            max = Math.Max(max,min * (j-i));
            if(height[i] < height[j]){
                i++;
            }
            else{
                j--;
            }
        }
        return max;
    }
}