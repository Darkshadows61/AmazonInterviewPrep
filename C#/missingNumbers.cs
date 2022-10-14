public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        {
            bool[] values = new bool[nums.Length + 1];
            foreach (var t in nums)
            {
                values[t] = true;
            }
            var result = new List<int>();
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == false)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}