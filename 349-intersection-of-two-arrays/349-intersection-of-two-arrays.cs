public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        List<int> finalArr = new List<int>();
         Array.Sort(nums1);
            for (int i = 0; i < nums2.Length; i++)
            {
                int output = binarySearch(nums1, nums2[i]);
                if (output != -1 && !finalArr.Contains(output))
                {
                    finalArr.Add(output);
                }
            }

            return finalArr.ToArray();
    }
    static int binarySearch(int[] arr, int target)
        {
            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    return arr[mid];
                }
                else if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else if (arr[mid] > target)
                {
                    end = mid - 1;
                }
            }

            return -1;
        }
}