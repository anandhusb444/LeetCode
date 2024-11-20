public class Solution {
    public int Reverse(int x) {

        var reverseNum = 0;

        while(x != 0)
        {
            var lastNumber = x % 10;
            
            if(reverseNum > int.MaxValue / 10 || reverseNum == int.MaxValue / 10 && lastNumber > 7)
            return 0;
            if(reverseNum < int.MinValue / 10 || reverseNum == int.MinValue / 10 && lastNumber < -8)
            return 0;

            reverseNum = reverseNum * 10 + lastNumber;
            x = x/10;
        }
        return reverseNum;
        
    }
}