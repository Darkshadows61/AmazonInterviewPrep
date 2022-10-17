public class Solution {
    public int Search(int[] nums, int target) {
        int i = 0;
        int j = nums.Length - 1;
        while (i <= j) {
            int k = i + (j - i) / 2;
            if (nums[k] == target) return k;
            if (nums[k] > target) j = k -1;
            else i = k +1;
        }
        return -1;
    }
}