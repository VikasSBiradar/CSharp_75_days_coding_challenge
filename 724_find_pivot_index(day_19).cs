public class Solution {
    public int PivotIndex(int[] nums) {
        int[] pre = new int[nums.Length];
        int sum = nums[0];
        pre[0] = 0;
        
        for(int i = 1; i < nums.Length; i++){
            sum+= nums[i];
            pre[i] = pre[i-1] + nums[i-1];
        }

        for(int i = 0; i <nums.Length; i++){
            if(pre[i] == sum - pre[i] - nums[i]){
                return i;
            }
        }
     return -1;   
    }
}