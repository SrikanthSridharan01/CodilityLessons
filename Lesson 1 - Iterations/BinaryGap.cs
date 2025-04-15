using System;

class Solution {
    public int solution(int N) {
        // Implement your solution here
        int gap = 0;
        int maxgap =0;
        Boolean between = false;
        string binaryinteger = Convert.ToString(N,2);
        foreach (int bit in binaryinteger)
        {
            if (bit == '1')
            {
                if(between)
                {
                    maxgap = Math.Max(gap, maxgap);
                }
                between = true;
                gap = 0;
            }
            else if (between)
            {
                gap++;
            }
        }
        return maxgap;
    }
}
