public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> result = new List<int>();

        int top = 0;
        int left = 0;
        int bottom = matrix.Length - 1;
        int right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
            {
                result.Add(matrix[top][i]);     
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i][right]);
            }
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }

        return result;

    }
}