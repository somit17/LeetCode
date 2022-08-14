public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] array1 = nums.Take(n).ToArray();
            int[] array2 = nums.Skip(n).ToArray();
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                result.Add(array1[i]);
                result.Add(array2[i]);
            }
        return result.ToArray();
    }
}