public class Solution {
    public int MaximumWealth(int[][] accounts) {
       int MaxSum = 0;
           for(int person = 0; person < accounts.Length; person++)
            {
                int rowSum = 0;
                for(int account = 0; account < accounts[person].Length; account++)
                {
                    rowSum += accounts[person][account];
                }
                if (rowSum > MaxSum)
                {
                    MaxSum = rowSum;
                }
            }
            return MaxSum; 
    }
}