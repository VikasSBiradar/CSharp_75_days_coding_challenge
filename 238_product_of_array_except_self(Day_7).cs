public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];

        prefix[0] = 1;
        for(int i = 1 ; i<nums.Length; i++){
            prefix[i] = prefix[i-1] * nums[i-1];
        }

        suffix[nums.Length - 1] = 1;
        for(int i = suffix.Length-2; i >=0; i--){
            suffix[i] = suffix[i+1] * nums[i+1];
        }

        int[] ans = new int[nums.Length];
        for(int i=0; i<nums.Length;i++){
            ans[i] = prefix[i]*suffix[i];
        }
        
        return ans;
    }
}