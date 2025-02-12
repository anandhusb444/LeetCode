public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        HashSet<int> numberList = new HashSet<int>();
        numberList.UnionWith(nums);
        List<int> result = new List<int>();

        for(int i=0; i<nums.Length; i++)
        {
            if(numberList.Contains(i+1) == false)
            {
                result.Add(i+1);
            }
        }
        return result;
    }
}