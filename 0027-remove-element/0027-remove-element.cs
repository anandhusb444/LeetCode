public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var len = nums.Length;
        var count = 0;
        for(int i=0; i<len;i++)
        {
           if(val != nums[i])
           {
            nums[count] = nums[i];
            count++;
           }
        }

        return count;
        
    }
}