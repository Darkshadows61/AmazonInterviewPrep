public class Solution {
    public int MissingNumber(int[] nums) {
        int expectedSum = 0;
        int actualSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            actualSum += nums[i];
            expectedSum += i + 1;
        }
        return expectedSum - actualSum;
    }
}