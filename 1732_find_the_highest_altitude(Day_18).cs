public class Solution {
    public int LargestAltitude(int[] gain) {
        int gainLength = gain.Length + 1;
        int[] altitudeArray = new int[gainLength];
        altitudeArray[0] = 0;
        for(int i = 1; i <gainLength; i++){
            altitudeArray[i] = altitudeArray[i-1] + gain[i-1];
        }
        int max = altitudeArray[0];
        for(int i = 1; i < altitudeArray.Length; i++){
            if(altitudeArray[i] > max){
                max = altitudeArray[i];
            }
        }
        return max;
    }
}