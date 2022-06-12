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
            if (NoOfDigits(num) % 2 == 0) return true;
            return false;
        }

        static int NoOfDigits(int num)
        {
            int count = 0;
            if (num < 0)
            {
                num = num * -1;
            }
            if (num == 0) return 1;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            return count;
        }
}