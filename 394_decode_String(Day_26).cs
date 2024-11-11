public class Solution {
    public string DecodeString(string s) {
        Stack<int> stNum = new Stack<int>();
        Stack<StringBuilder> stStr = new Stack<StringBuilder>();

        StringBuilder currStr = new StringBuilder();
        int currNum = 0;

        foreach (char ch in s) {
            if (ch == '[') {
                stNum.Push(currNum);
                stStr.Push(currStr);
                currNum = 0;
                currStr = new StringBuilder();
            } 
            else if (ch == ']') {
                int num = stNum.Pop();
                StringBuilder prevStr = stStr.Pop();
                string currString = currStr.ToString();
                currStr = prevStr.Append(string.Concat(Enumerable.Repeat(currString, num)));
            } 
            else if (ch >= '0' && ch <= '9') {
                currNum = currNum * 10 + (ch - '0');
            } 
            else {
                currStr.Append(ch);
            }
        }

        return currStr.ToString();
    }
}