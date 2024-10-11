public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0){
            return true;
        }
        int i = 0;
        int j = 0;
        while(i < s.Length && j < t.Length ){
            if(s[i] == t[j])
            {
                i++;
                j++;
            }
            else{
                j++;
            }
        }
        if(s.Length == i){
            return true;
        }
        return false;
    }
}