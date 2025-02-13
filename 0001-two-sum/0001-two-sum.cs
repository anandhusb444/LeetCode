public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> map = new Dictionary<int,int>();

        for(int i=0; i<nums.Length; i++)
        {
            int targetVal = target - nums[i];
            if(map.Contains(targetVal))
            {
                return new int[] {targetVal,nums[i]};
            }

            if(map.Contains(nums[i]) == false)
            {
                map[nums[i]] = 1;
            }
        }
        return null;
        
        
    }
}