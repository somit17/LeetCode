public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> output = new List<bool>();
            int max = MaxNum(candies);
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    output.Add(true);
                }
                else
                {
                    output.Add(false);
                }
            }

            return output;
    }
    
     static int MaxNum(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
}