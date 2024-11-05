public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var maxCount = 0;
        for(int i=0; i<s.Length; i++)
        {
            HashSet<char> set = new HashSet<char>();
            var count = 0;
            for(int j=i; j<s.Length; j++)
            {
                if(set.Contains(s[j]))
                {
                    break;
                }
                else
                {
                    set.Add(s[j]);
                    count++;
                }
                maxCount = Math.Max(maxCount,count);
            }
        }
        return maxCount;
    }
}