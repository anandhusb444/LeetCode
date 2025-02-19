/**
 * @param {number[][]} matrix
 * @return {number[]}
 */
var spiralOrder = function(m) {
    let result = [];
    var top = 0;
    var bottom = m.length - 1;
    var left = 0;
    var right = m[0].length - 1;

    while(top <= bottom && left <= right)
    {
        for(let i = left; i<= right; i++)
        {
            result.push(m[top][i]);
        }
        top++;
        for(let i = top; i<= bottom; i++)
        {
            result.push(m[i][right])
        }
        right--;
        if(top <= bottom)
        {
            for(let i = right; i>= left; i--)
            {
                result.push(m[bottom][i])
            }
            bottom--;
        }
        if(left <= right)
        {
            for(let i = bottom; i>=top; i--)
            {
                result.push(m[i][left]);
            }
            left++;
        }
    }
    return result;
};