using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int len = A.Length;
        int mindiff = int.MaxValue;
        int arraysum = A.Sum();
        int leftsplitsum = 0;
        for (int i=1; i<len; i++)
        {
            leftsplitsum = leftsplitsum+A[i-1];
            int rightsplitsum = arraysum-leftsplitsum;
            int diff = Math.Abs(rightsplitsum-leftsplitsum);
            if (diff<mindiff)
                {
                    mindiff=diff;
                }
        }       
        return mindiff;
    }
}
