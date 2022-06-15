public class Solution {
    public int MissingNumber(int[] nums) {
        int len = nums.Length;
            Array.Sort(nums);
            for (int i = 0; i <= len; i++)
            {
                if(i==len)
                    return i;
                else if(nums[i]!=i)
                    return i;
            }

            return 0;
    }
}