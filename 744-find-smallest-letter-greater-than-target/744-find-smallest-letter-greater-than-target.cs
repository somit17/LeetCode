public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
         int start = 0, end = letters.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (target < letters[mid])
                {
                    end = mid - 1;
                }
                else{
                    start = mid + 1;
                }
            }

            return letters[start % letters.Length];
    }
}