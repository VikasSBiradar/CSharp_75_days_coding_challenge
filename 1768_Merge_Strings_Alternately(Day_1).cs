public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder sb = new StringBuilder();
        int i = 0;
        int j = 0;
        bool flag = true;

        while(i < word1.Length && j < word2.Length){
            if(flag){
              sb.Append(word1[i]);
              i++;
            }
            else{
              sb.Append(word2[j]);
              j++;
            }
            flag = !flag;
        }

        while(i< word1.Length){
            sb.Append(word1[i]);
            i++;
        }

        while(j<word2.Length){
            sb.Append(word2[j]);
            j++;
        }

        return sb.ToString();
    }
}