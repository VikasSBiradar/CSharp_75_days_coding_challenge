public class Solution {
    public string RemoveStars(string s) {
        Stack remove_star = new Stack();
        for(int i=0; i<s.Length; i++){
            if(s[i] != '*'){
                remove_star.Push(s[i]);
            }
            else{
                remove_star.Pop();
            }
        }

        if(remove_star.Count == 0){
            return "";
        }

        StringBuilder sb = new StringBuilder();
        while(remove_star.Count != 0){
            sb.Insert(0, remove_star.Pop());
        }
        return sb.ToString();
    }
}