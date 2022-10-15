public class Solution {
    public int[] CountBits(int n) {
        int[] arr = new int[n+1];
        for(int i=0;i<=n;i++)
        {
            arr[i] = Convert.ToString(i, 2).Count(x => x == '1');
        }
        return arr;        
    }
}