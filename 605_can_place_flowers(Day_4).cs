public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int total = 0;
        for(int i=0; i<flowerbed.Length; i++){
            if(flowerbed[i]==0){
            int next = (i == flowerbed.Length - 1) ? 0 : flowerbed[i + 1];
            int prev = (i == 0) ? 0 : flowerbed[i - 1];
                if(next == 0 && prev == 0){
                    total++;
                    flowerbed[i]=1;

                     if (total >= n) {
                        return true;
                    }
                }
            }
        }
       return total>=n; 
    }
}