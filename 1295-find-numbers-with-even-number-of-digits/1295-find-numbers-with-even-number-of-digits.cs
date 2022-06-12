public class Solution {
    public int FindNumbers(int[] nums) {
        int Count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (IsEven(nums[i])) Count++;
            }
            return Count;
    }
    static bool IsEven(int num)
        {
            if (digits2(num) % 2 == 0) return true;
            return false;
        }

        static int digits2(int num) {
            if (num < 0)
            {
                num = num * -1;
            }
            return (int)Math.Log10(num) + 1;
        }
}