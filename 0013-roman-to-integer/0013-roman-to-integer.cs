public class Solution {
    public int RomanToInt(string s) {
        
        Dictionary<char, int> romanMap = new Dictionary<char,int>()
     {
        {'I',1},
        {'V',5},
        {'X',10},
        {'L',50},
        {'C',100},
        {'D',500},
        {'M',1000}
     };

     int total = 0;
     int prevsVal = 0;

     for(int i=s.Length-1; i>=0; i--)
     {
        var currChar = s[i];
        var currValue = romanMap[currChar];

        if(currValue < prevsVal)
        {
            total -= currValue;
        }
        else
        {
            total += currValue;
        }
        prevsVal = currValue;
     }
        
        return total;
        
    }
}