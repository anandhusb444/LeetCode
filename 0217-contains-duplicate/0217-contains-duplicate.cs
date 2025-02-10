public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        
        foreach(int num in nums)
        {
            set.Add(num);
        }

        if(set.Count < nums.Length)
        {
            return true;
        }
        else
        {
            return false;
        }


    }
}