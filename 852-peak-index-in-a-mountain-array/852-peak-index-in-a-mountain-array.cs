public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int start = 0, end = arr.Length - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] > arr[mid + 1])
                {
                    //you are in dec part of array this may be possible ans but look at left 
                    end = mid;
                }
                else 
                {
                    //you are in asc part of array
                    start = mid + 1;
                }
            }

            return start;
    }
}