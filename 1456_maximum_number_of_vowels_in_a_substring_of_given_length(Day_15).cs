public class Solution {
    public int MaxVowels(string s, int k) {
        int count = 0;
        int ans = 0;

        for(int i = 0; i < k; i++){
            char ch = s[i];
            if(isVowel(ch)){
                count++;
            }
        }
        ans = count;

        for(int i = k; i< s.Length; i++){
            char chi = s[i];
            char chimk = s[i - k];
            if(isVowel(chi)){
                count++;
            }
            if(isVowel(chimk)){
                count--;
            }

            ans = Math.Max(count,ans);
        }
        return ans;
    }

    public bool isVowel(char ch){
        if(ch == 'a'){
            return true;
        }
        else if(ch == 'e'){
            return true;
        }
        else if(ch == 'i'){
            return true;
        }
        else if(ch == 'o'){
            return true;
        }
        else if(ch == 'u'){
            return true;
        }
        else{
            return false;
        }
    }
}