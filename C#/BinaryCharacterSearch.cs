public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        Array.Sort(letters);
        int targetI = Array.IndexOf(letters, target);
        return letters[targetI + 1];
    }
}