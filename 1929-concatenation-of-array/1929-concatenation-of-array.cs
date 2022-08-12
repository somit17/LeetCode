public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int length = nums.Length;
            int[] newArray = new int[2 * length];
            for (int i = 0; i < length; i++)
            {
                newArray[i] = nums[i];
                newArray[i + length] = nums[i];
                //Console.Write(newArray[i]);
            }
            return newArray;
    }
}