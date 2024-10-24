public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var countMap = new Dictionary<int,int>();

        foreach(var num in arr){
            if(countMap.ContainsKey(num)){
                countMap[num]++;
            }
            else{
                countMap[num] = 1;
            }
        }

        var occurencesSet = new HashSet<int>();
        foreach(var count in countMap.Values){
            if(!occurencesSet.Add(count)){
                return false;
            }
        }
        return true;
    }
}