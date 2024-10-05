public class Solution {
    public string ReverseVowels(string s) {
        char[] wordArray = s.ToCharArray();
        int left = 0;
        int right = wordArray.Length - 1;
        while(left < right){
            char chl = wordArray[left];
            char chr = wordArray[right];

            if(isVowel(chl) && isVowel(chr)){
                    wordArray[left] = chr;
                     wordArray[right]=chl;
                     left++;
                     right--;
            }
            else if(isVowel(chl)){
                right--;
            }
            else if(isVowel(chr)){
                left++;
            }
            else{
                left++;
                right--;
            }
        }
        return new String(wordArray);
    }

    bool isVowel(char ch){
        if(ch == 'a' || ch == 'A'){
            return true;
        }
        else if(ch == 'e' || ch == 'E'){
            return true;
        }
        else if(ch == 'i' || ch == 'I'){
            return true;
        }
        else if(ch == 'o' || ch == 'O'){
            return true;
        }
        else if(ch == 'u' || ch == 'U'){
            return true;
        }
        else{
            return false;
        }
    }
}