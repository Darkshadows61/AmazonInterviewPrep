public class Solution {
    public int ClimbStairs(int n) {
    int oneStep = 1;
    int twoSteps = 2;
    int result = 0;

    if (n < 3) {
        return n;
    }
    for (int i = 3; i <= n; i++) {
        result = twoSteps + oneStep;
        oneStep = twoSteps;
        twoSteps = result;
    }
    return result;
    }
}