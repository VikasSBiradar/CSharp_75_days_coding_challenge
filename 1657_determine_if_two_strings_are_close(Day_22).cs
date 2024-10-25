public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if(word1.Length != word2.Length){
            return false;
        }

        var count1 = new Dictionary<char,int>();
        var count2 = new Dictionary<char,int>();

        foreach(var c1 in word1){
            if(count1.ContainsKey(c1)){
                count1[c1]++;
            }
            else{
                count1[c1] = 1;
            }
        }

        foreach(var c2 in word2){
            if(count2.ContainsKey(c2)){
                count2[c2]++;
            }
            else{
                count2[c2] = 1;
            }
        }
        
        if(!count1.Keys.OrderBy(k => k).SequenceEqual(count2.Keys.OrderBy(k => k))){
                return false;
        }

        var freq1 = count1.Values.ToList();
        var freq2 = count2.Values.ToList();

        freq1.Sort();
        freq2.Sort();

        return freq1.SequenceEqual(freq2);
    }
}