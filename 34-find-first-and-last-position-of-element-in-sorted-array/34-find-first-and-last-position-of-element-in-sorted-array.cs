public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] ans =
            {
                -1,-1
            };
            ans[0] = binarySearch(nums, target, findStartIndex: true);
            ans[1] = binarySearch(nums, target, findStartIndex: false);
            return ans;
    }
    static int binarySearch(int[] nums, int target, bool findStartIndex)
        {
            int start = 0, end = nums.Length-1,ans=-1;
            while (start <= end)
            {
                int mid =start+(end-start) / 2;
                if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else if ( target>nums[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    //potential ans found
                    ans = mid;
                    if (findStartIndex)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
            }

            return ans;
        }
}