public class Solution {
    public int MaxArea(int[] height) {
        var maxWater = 0;
        var left = 0;
        var right = height.Length-1;

        while(left < right)
        {
            var width = right - left;
            var minH = Math.Min(height[left],height[right]);
            var currentWater = width * minH;
            maxWater = Math.Max(currentWater,maxWater);

            if(height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }

        }
        return maxWater;

        return maxWater;
    }
}