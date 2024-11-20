public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;

        var reverseNum = 0;

        var duplicate = x ;
        while(x != 0)
        {
            var lastnumber = x % 10;
            
            

            reverseNum = reverseNum * 10 + lastnumber;
            x = x/10;
        }

      return duplicate == reverseNum;

    }
}