public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();
        foreach(int val in nums1){
            set1.Add(val);
        }
        foreach(int val in nums2){
            set2.Add(val);
        }

        HashSet<int> ans1 = new HashSet<int>();
        HashSet<int> ans2 = new HashSet<int>();

        foreach(int val in nums1){
            if(set2.Contains(val)== false){
                ans1.Add(val);
            }
        }

        foreach(int val in nums2){
            if(set1.Contains(val) == false){
                ans2.Add(val);
            }
        }

      return new List<IList<int>>{new List<int>(ans1), new List<int>(ans2)};
    }
}