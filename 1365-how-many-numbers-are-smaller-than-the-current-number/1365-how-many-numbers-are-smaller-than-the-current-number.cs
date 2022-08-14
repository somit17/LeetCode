public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
      int[] bucket = new int[102];
            //Create a bucket 
            foreach (int num in nums)
            {
                bucket[num]++;
            }
            
            //Count smaller number than each element
            for (int i = 1; i < bucket.Length; i++)
            {
                bucket[i]+=bucket[i-1];
            }
            
            //Populate result
            int[] result = new int[nums.Length]; 
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = bucket[nums[i] - 1];
                }
            }
            return result;
    }
    
}