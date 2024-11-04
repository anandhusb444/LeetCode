public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var val = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] == target)
            {
                val = i;
            }
            else if(nums[i] + 1 == target)
            {
                val = i + 1;
            }

        }
        return val;
    }
}