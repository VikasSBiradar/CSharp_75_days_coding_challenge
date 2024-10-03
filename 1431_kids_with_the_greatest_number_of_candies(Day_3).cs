public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
    
        int maxCandies = candies.Max();
        List<bool> canHaveMax = new List<bool>();

        for(int i=0; i<candies.Length; i++)
        {
            if(candies[i]+extraCandies >= maxCandies){
                canHaveMax.Add(true);
            }
            else{
                canHaveMax.Add(false);
            }
        }
        return canHaveMax;
    }
}