public class Solution {
    public int MaxOperations(int[] nums, int k) {
        int ans = 0;
        Array.Sort(nums);
        int i = 0; 
        int j = nums.Length - 1;
        while(i < j){
            if(nums[i] + nums[j] < k){
                i++;
            }
            else if (nums[i] + nums[j] > k){
                j--;
            }
            else{
                i++;
                j--;
                ans++;
            }
        }
        return ans++;
    }
}