public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] newArray = new int [nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                newArray[i] = sum + nums[i];
                sum = newArray[i];
                //Console.Write(newArray[i]);
            }
        return newArray;
    }
}