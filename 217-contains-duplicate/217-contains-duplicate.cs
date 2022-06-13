public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        bool result = false;
            Array.Sort(nums);
            for(int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    result = true;
                    break;
                }
            }
            return result;
    }
}