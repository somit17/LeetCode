public class Solution {
    public int SearchInsert(int[] nums, int target) {
             int start = 0, end = nums.Length-1,mid=0;
            if (nums.Length == 0)
            {
                return 0;
            }

            while (start <= end)
            {
                mid = start + (end - start) / 2;
                
                if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else 
                {
                    return mid;
                }
            }
            return start;
    }
}