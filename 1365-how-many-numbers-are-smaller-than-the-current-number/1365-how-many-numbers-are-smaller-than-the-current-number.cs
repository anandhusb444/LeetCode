public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var array = new List<int>();
        for(int i=0; i<nums.Length; i++)
        {
            var count = 0;
            for(int j=0; j<nums.Length; j++)
            {
                if(nums[j] < nums[i])
                {
                    count++;
                }

            }
            array.Add(count);

        }
        return array.ToArray();
    }
}