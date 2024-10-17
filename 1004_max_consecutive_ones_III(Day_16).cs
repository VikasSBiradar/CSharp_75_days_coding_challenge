public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int i = 0, j = 0, zeroCount = 0,ans = 0,n = nums.Length;
            while(j < n){
                if(nums[j] == 0){
                    zeroCount++;
                }
                while(zeroCount > k){
                    if(nums[i] == 0){
                        zeroCount--;
                    }
                    i++;
                }
                ans = Math.Max(ans, j-i+1);
                j++;
            }
        return ans;
    }
}