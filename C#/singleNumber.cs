public class Solution {
    public int SingleNumber(int[] nums) {
        // sort through an array to find a number that only appears one time
        // 
        var r = nums.GroupBy(x => x).Select(x => x).FirstOrDefault(x => x.Count() == 1);
        return r.Key;
    }
}