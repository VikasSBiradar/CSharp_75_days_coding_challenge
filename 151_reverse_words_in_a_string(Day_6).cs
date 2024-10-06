public class Solution {
    public string ReverseWords(string s) {
        var words = s.Trim().Split(' ');
        StringBuilder sb = new StringBuilder();

        for(int i = words.Length - 1; i >= 0; i--){
            if(words[i].Length > 0){
                sb.Append(words[i]);
                if(i > 0)
                {
                    sb.Append(' ');
                }
                
            }
        }
        return sb.ToString();
    }
}