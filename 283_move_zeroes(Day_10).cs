public class Solution {
    public void MoveZeroes(int[] nums) {
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i]!=0){
                nums[count++]=nums[i];
            }
        }
        while(count < nums.Length ){
            nums[count++]=0;
        }
    }
}