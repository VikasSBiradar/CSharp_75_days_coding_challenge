public class Solution {
    public int Compress(char[] chars) {
        StringBuilder sb = new StringBuilder();
        int i = 1;
        int count = 1;
        sb.Append(chars[0]);

        while(i<chars.Length){
            if(chars[i] == chars[i-1]){
                count++;
            }
            else{
                if(count > 1){
                    sb.Append(count);
                }
                sb.Append(chars[i]);
                count = 1;
            }
            i++;
        }
        
        if(count > 1){
            sb.Append(count);
        }

        for(int j = 0; j < sb.Length; j++){
            chars[j] = sb[j];
        }

        return sb.Length;
    }
}
