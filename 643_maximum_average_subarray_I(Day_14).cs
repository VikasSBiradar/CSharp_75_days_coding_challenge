public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double avg = 0.00;
        double ans = 0.00;

        int sum = 0;
        for(int i = 0; i < k; i++){
            sum += nums[i];
        }
        avg = sum * 1.0/ k;
        ans = avg;

        for(int i=k ; i< nums.Length; i++){
            sum += nums[i] - nums[i-k];
            avg = sum * 1.0/k;
            ans = Math.Max(ans,avg);
        }
        return ans;
        
    }
}
